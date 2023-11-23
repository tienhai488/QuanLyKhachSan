namespace HotelManagement.Business
{
    using HotelManagement.Data.Access;
    using HotelManagement.Data;
    using HotelManagement.Validations;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class AccountManagerBO
    {
        private static object syncKey = new();
        private static AccountManagerBO? bo;
        public static AccountManagerBO Instance
        {
            get
            {
                if (bo == null)
                    lock (syncKey)
                    {
                        bo ??= new AccountManagerBO();
                    }
                return bo;
            }
        }

        public Account? SelectedAccount { get; set; }

        private BigInteger usableUid;
        private IList<Account>? accounts, lookedUpAccounts;
        public IList<Account> Accounts
        {
            get
            {
                if (lookedUpAccounts != null)
                    return lookedUpAccounts;

                if (accounts == null)
                    lock (syncKey)
                    {
                        if (accounts == null)
                            using (var dao = new AccountEFCoreDAO())
                            {
                                accounts = dao.NormalAccounts.ToList();
                                usableUid = dao.UsableUid;
                            }
                    }
                return accounts;
            }
        }

        public bool Searching
        {
            get => lookedUpAccounts != null;
            set
            {
                if (lookedUpAccounts != null == value) return;
                lookedUpAccounts = value ? new List<Account>(Accounts) : null;
            }
        }

        private bool creating;

        public void CreateAccount()
        {
            if (Searching) return;
            SelectedAccount = new(usableUid);
            creating = true;
        }

        public void LookupAccount(string text)
        {
            if (!Searching) return;
            var lookedUp = lookedUpAccounts;
            if (lookedUp == null) return;
            lookedUp.Clear();
            var accounts = this.accounts;
            if (accounts == null) return;
            foreach (var item in accounts)
            {
                if (item.UserName.Contains(text, StringComparison.CurrentCultureIgnoreCase))
                    lookedUp.Add(item);
            }
        }

        public bool CanDelete
        {
            get
            {
                var account = SelectedAccount;
                return account != null && !account.Linked;
            }
        }

        public bool CanDisable
        {
            get
            {
                var account = SelectedAccount;
                return account != null && account.Linked;
            }
        }

        public void DeleteAccount()
        {
            if (Searching) return;
            if (SelectedAccount == null) return;
            lock (syncKey)
            {
                var account = SelectedAccount;
                if (account != null && account.Uid != 0 && !account.Linked)
                {
                    using (var dao = new AccountEFCoreDAO())
                    {
                        dao.Remove(account);
                        dao.SaveChanges();
                        accounts = dao.NormalAccounts.ToList();
                        usableUid = dao.UsableUid;
                    }
                    SelectedAccount = null;
                }
            }
        }

        public void AcceptEdit()
        {
            if (Searching) return;
            if (SelectedAccount == null) return;
            lock (syncKey)
            {
                var account = SelectedAccount;
                if (account != null)
                {
                    using (var dao = new AccountEFCoreDAO())
                    {
                        if (creating)
                        {
                            dao.Add(account);
                            creating = false;
                        }
                        else dao.Update(account);
                        dao.SaveChanges();
                        accounts = dao.NormalAccounts.ToList();
                        usableUid = dao.UsableUid;
                    }
                }
            }
        }

        public void CancelEdit()
        {
            if (Searching) return;
            if (creating)
            {
                SelectedAccount = null;
                creating = false;
            }
        }

        public bool IsValidUserName(string? userName) => userName.IsValidUserName();
        public bool IsValidPassword(string? password) => password.IsValidPassword();

        private AccountManagerBO() { }
    }
}

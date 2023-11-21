namespace HotelManagement.Validations
{
    using System;

    public static class ValidationsExtensions
    {
        public static unsafe bool IsValidUserName(this string userName)
        {
            if (userName is null) return false;
            int length = userName.Length;
            if (length < 6) return false;
            fixed (char* pUserName = userName)
            {
                char* pStart = pUserName, pEnd = pStart + (length - 1);
                if (*pStart is '.' or '_' || *pEnd is '.' or '_') return false;
                for (; pStart <= pEnd; ++pStart)
                {
                    if (*pStart is (< 'a' or > 'z') and (< 'A' or > 'Z')
                            and (< '0' or > '9') and not '.' and not '_')
                        return false;
                }
            }
            return true;
        }

        public static unsafe string AsValidUserName(this string userName)
        {
            if (userName is null) goto except;
            int length = userName.Length;
            if (length == 0) goto except;
            char[] convertedUserName;
            fixed (char* pUserName = userName)
            {
                char* pStart = pUserName, pEnd = pStart + (length - 1);
                for (; pStart <= pEnd && char.IsWhiteSpace(*pStart); ++pStart) ;
                for (; pStart <= pEnd && char.IsWhiteSpace(*pEnd); --pEnd) ;
                if (pStart + 5 > pEnd) goto except;
                convertedUserName = new char[pEnd - pStart + 1];
                fixed (char* pConverted = convertedUserName)
                {
                    for (char* ptr = pConverted; pStart <= pEnd; ++ptr, ++pStart)
                    {
                        char value = *pStart;
                        *ptr = value is >= 'a' and <= 'z' or >= '0' and <= '9' or '.' ? value
                            : value is >= 'A' and <= 'Z' ? (char)(value - 'A' + 'a') : '_';
                    }
                }
            }
            return new string(convertedUserName);
        except:
            throw new ArgumentException("'userName' is not valid!", nameof(userName));
        }

        public static unsafe bool IsValidName(this string userName)
        {
            if (userName is null) return false;
            int length = userName.Length;
            fixed (char* pUserName = userName)
            {
                char* pStart = pUserName, pEnd = pStart + (length - 1);
                if (*pStart is '.' or '_' || *pEnd is '.' or '_') return false;
                for (; pStart <= pEnd; ++pStart)
                {
                    if (*pStart is (< 'a' or > 'z') and (< 'A' or > 'Z')
                            and (< '0' or > '9') and not '.' and not '_')
                        return false;
                }
            }
            return true;
        }

        public static unsafe string AsValidName(this string userName)
        {
            if (userName is null) goto except;
            int length = userName.Length;
            if (length == 0) goto except;
            char[] convertedUserName;
            fixed (char* pUserName = userName)
            {
                char* pStart = pUserName, pEnd = pStart + (length - 1);
                for (; pStart <= pEnd && char.IsWhiteSpace(*pStart); ++pStart) ;
                for (; pStart <= pEnd && char.IsWhiteSpace(*pEnd); --pEnd) ;
                if (pStart > pEnd) goto except;
                convertedUserName = new char[pEnd - pStart + 1];
                fixed (char* pConverted = convertedUserName)
                {
                    for (char* ptr = pConverted; pStart <= pEnd; ++ptr, ++pStart)
                    {
                        char value = *pStart;
                        *ptr = value is >= 'a' and <= 'z' or >= '0' and <= '9' or '.' ? value
                            : value is >= 'A' and <= 'Z' ? (char)(value - 'A' + 'a') : '_';
                    }
                }
            }
            return new string(convertedUserName);
        except:
            throw new ArgumentException("'userName' is not valid!", nameof(userName));
        }

        public static unsafe bool IsValidPassword(this string password)
        {
            if (password is null) return false;
            int length = password.Length;
            if (length < 8) return false;
            fixed (char* pUserName = password)
            {
                char* pStart = pUserName, pEnd = pStart + (length - 1);
                for (bool hasUpper = false, hasLower = false, hasNumber = false, hasSymbol = false; pStart <= pEnd; ++pStart)
                {
                    char c = *pStart;
                    if (char.IsUpper(c))
                    {
                        if (!hasUpper)
                        {
                            if (hasLower && hasNumber && hasSymbol) return true;
                            hasUpper = true;
                        }
                    }
                    else if (char.IsLower(c))
                    {
                        if (!hasLower)
                        {
                            if (hasUpper && hasNumber && hasSymbol) return true;
                            hasLower = true;
                        }
                    }
                    else if (char.IsNumber(c))
                    {
                        if (!hasNumber)
                        {
                            if (hasUpper && hasLower && hasSymbol) return true;
                            hasNumber = true;
                        }
                    }
                    else if (!char.IsControl(c))
                    {
                        if (!hasSymbol)
                        {
                            if (hasUpper && hasLower && hasNumber) return true;
                            hasSymbol = true;
                        }
                    }
                    else return false;
                }
            }
            return false;
        }

        public static string AsValidPassword(this string password)
            => password.IsValidPassword() ? password
                : throw new ArgumentException("'password' is not valid!", nameof(password));
    }
}

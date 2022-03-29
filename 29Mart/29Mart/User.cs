using System;
using System.Collections.Generic;
using System.Text;

namespace _29Mart
{
    class User
    {
        public User(string UserName)
        {
            UserNameTool = UserName;
            
        }
        int count = 0;
        int countTwo = 0;
        int countThree = 0;
        int result = 0;
        private string _userName;
        private string _passWord;

        public string UserNameTool 
        { 
            get 
            {
                return _userName;
            }
            private set 
            {
                    if (value.Length > 6 && value.Length < 25)
                    {
                        this._userName = value;
                    }
            }
        }
        public string PassWord 
        { 
            get 
            {
                return this._passWord;
            }
            set
            {
                if (value.Length > 8 && value.Length < 25)
                {
                    
                    if (HasDigit(value) == true && count < 1)
                    {
                        count++;
                    }
                    if (HasUpper(value) == true && countTwo < 1)
                    {
                        countTwo++;
                    }
                    if (HasLower(value) == true && countThree < 1)
                    {
                        countThree++;
                    }
                    result = count + countTwo + countThree;
                    if (result > 2)
                    {
                        this._passWord = value; 
                    }
                    

                }
            } 
        }

        public bool HasDigit(string DigitTool) 
        {
            for (int i = 0; i < DigitTool.Length; i++)
            {
                if (char.IsDigit(DigitTool[i]))
                {
                    return true;
                }
            }return false;
        }

        public bool HasUpper(string UpperTool) 
        {
            for (int i = 0; i < UpperTool.Length; i++)
            {
                if (char.IsUpper(UpperTool[i]))
                {
                    return true;
                }
            }return false;
        }
        public bool HasLower(string LowerTool) 
        {
            for (int i = 0; i < LowerTool.Length; i++)
            {
                if (char.IsLower(LowerTool[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public void GetInfo(string UserName,string PassWord) 
        {
            Console.WriteLine($"Your acoount name is {UserName} and password is {PassWord}");
        }
    }
}

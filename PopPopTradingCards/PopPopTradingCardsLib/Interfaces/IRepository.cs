﻿using System;
using System.Collections.Generic;
using System.Text;
using PopPopTradingCardsLib.Models;

namespace PopPopTradingCardsLib.Interfaces
{
    public interface IRepository
    {
        public void CreateAccount(string name, string pass);
        public bool Login(string name, string pass);
    }
}
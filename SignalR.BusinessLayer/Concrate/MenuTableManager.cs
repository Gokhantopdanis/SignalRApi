﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.Abstract
{
    public class MenuTableManager : IMenuTableService
    {
        private readonly IMenuTableDal _menuTableDal;

        public MenuTableManager(IMenuTableDal menuTableDal)
        {
            _menuTableDal = menuTableDal;
        }

        public void Tadd(MenuTable entity)
        {
            _menuTableDal.Add(entity);
        }

        public void TChangeMenuTableStatusFalse(int id)
        {
            _menuTableDal.ChangeMenuTableStatusFalse(id);
        }

        public void TChangeMenuTableStatusTrue(int id)
        {
            _menuTableDal.ChangeMenuTableStatusTrue(id);
        }

        public void TDelete(MenuTable entity)
        {
            _menuTableDal.Delete(entity);
        }

        public MenuTable TGetById(int id)
        {
            return _menuTableDal.GetByID(id);
        }

        public List<MenuTable> TGetListAll()
        {
            return _menuTableDal.GetListAll();
        }

        public int TMenuTableCount()
        {
            return _menuTableDal.MenuTableCount();
        }

        public void Tupdate(MenuTable entity)
        {
            _menuTableDal.Update(entity);
        }
    }
}

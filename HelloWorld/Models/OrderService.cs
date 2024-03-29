﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        /// <param name="order"></param>
        public void InsertOrder(Models.Order order)
        {
            //todo
        }
        /// <summary>
        /// 依照Id 取得訂單資料
        /// </summary>
        /// <returns></returns>
        public Models.Order GetOrderById(string orderId)
        {
            Order result = new Order(){
                CustId = "GSS",
                CustName = "叡揚資訊"
            };
            return result;
        }
        /// <summary>
        /// 依照條件取得訂單資料
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrderByCondition()
        {
            //todo
            List<Models.Order> result = new List<Order>();
            result.Add(new Order() { CustId = "001", CustName = "叡揚資訊", EmpId = 1, EmpName = "王小明", Orderdate = DateTime.Parse("2015/11/08") });
            result.Add(new Order() { CustId = "002", CustName = "網軟資訊", EmpId = 2, EmpName = "李小華", Orderdate = DateTime.Parse("2015/11/01") });
            return result;
        }
        /// <summary>
        /// 刪除訂單
        /// </summary>
        public void DeleteOrderById(string orderId)
        {
            //todo
        }
        /// <summary>
        /// 更新訂單
        /// </summary>
        public void UpdateOrder(Models.Order order)
        {
            //todo
        }

    }
}
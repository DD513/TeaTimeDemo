using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTimeDemo.Utility
{
    public static class SD
    {
        public const string Role_Customer = "Customer";
        public const string Role_Employee = "Employee";
        public const string Role_Manager = "Manager";
        public const string Role_Admin = "Admin";

		// 等待店家確認訂單 -> 店家確認後改為訂單準備中 -> 店家準備完成後改為訂單完成、可取餐 -> 使用者取餐後改為訂單完成

		public const string StatusPending = "Pending"; // 等待店家確認訂單

		//public const string StatusApproved = "Approved"; 
		public const string StatusInProcess = "Processing"; // 店家確認後改為訂單準備中
		public const string StatusCancelled = "Cancelled"; // 店家或顧客取消訂單

		public const string StatusReady = "Ready"; // 店家準備完成，顧客可以取餐
		public const string StatusCompleted = "Completed"; // 顧客取餐及付款後，店家結束訂單
    }
}
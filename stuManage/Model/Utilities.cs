﻿using System;
namespace stuManage.Model
{
	/// <summary>
	/// Utilities:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Utilities
	{
		public Utilities()
		{}
		#region Model
		private string _number;
		private string _flo_num;
		private string _dor_num;
		private string _month_;
        private string _electricity;
        private string _ele_fee;
        private string _water;
        private string _wat_fee;
		/// <summary>
		/// 
		/// </summary>
		public string number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string flo_num
		{
			set{ _flo_num=value;}
			get{return _flo_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dor_num
		{
			set{ _dor_num=value;}
			get{return _dor_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string month_
		{
			set{ _month_=value;}
			get{return _month_;}
		}
		/// <summary>
		/// 
		/// </summary>
        public string electricity
		{
			set{ _electricity=value;}
			get{return _electricity;}
		}
		/// <summary>
		/// 
		/// </summary>
        public string ele_fee
		{
			set{ _ele_fee=value;}
			get{return _ele_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
        public string water
		{
			set{ _water=value;}
			get{return _water;}
		}
		/// <summary>
		/// 
		/// </summary>
        public string wat_fee
		{
			set{ _wat_fee=value;}
			get{return _wat_fee;}
		}
		#endregion Model

	}
}


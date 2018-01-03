/**  版本信息模板在安装目录下，可自行修改。
* Utilities.cs
*
* 功 能： N/A
* 类 名： Utilities
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018-01-02 22:07:09   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
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
		private string _flo_num;
		private string _dor_num;
		private string _month_;
		private decimal _electricity;
		private decimal _ele_fee;
		private decimal _water;
		private decimal _wat_fee;
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
		public decimal electricity
		{
			set{ _electricity=value;}
			get{return _electricity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal ele_fee
		{
			set{ _ele_fee=value;}
			get{return _ele_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal water
		{
			set{ _water=value;}
			get{return _water;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal wat_fee
		{
			set{ _wat_fee=value;}
			get{return _wat_fee;}
		}
		#endregion Model

	}
}


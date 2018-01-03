/**  版本信息模板在安装目录下，可自行修改。
* Repair.cs
*
* 功 能： N/A
* 类 名： Repair
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018-01-02 22:07:08   N/A    初版
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
	/// Repair:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Repair
	{
		public Repair()
		{}
		#region Model
		private string _flo_num;
		private string _dor_num;
		private string _art_num;
		private string _repa_rea;
		private DateTime _sub_date;
		private DateTime _sol_date;
		private decimal _repa_fee;
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
		public string art_num
		{
			set{ _art_num=value;}
			get{return _art_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string repa_rea
		{
			set{ _repa_rea=value;}
			get{return _repa_rea;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime sub_date
		{
			set{ _sub_date=value;}
			get{return _sub_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime sol_date
		{
			set{ _sol_date=value;}
			get{return _sol_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal repa_fee
		{
			set{ _repa_fee=value;}
			get{return _repa_fee;}
		}
		#endregion Model

	}
}


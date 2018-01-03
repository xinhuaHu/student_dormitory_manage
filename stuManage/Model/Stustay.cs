/**  版本信息模板在安装目录下，可自行修改。
* Stustay.cs
*
* 功 能： N/A
* 类 名： Stustay
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
	/// Stustay:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Stustay
	{
		public Stustay()
		{}
		#region Model
		private string _num;
		private string _name;
		private string _sex="男";
		private string _profession;
		private DateTime _check_time;
		private string _flo_num;
		private string _dor_num;
		/// <summary>
		/// 
		/// </summary>
		public string num
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string profession
		{
			set{ _profession=value;}
			get{return _profession;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime check_time
		{
			set{ _check_time=value;}
			get{return _check_time;}
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
		#endregion Model

	}
}


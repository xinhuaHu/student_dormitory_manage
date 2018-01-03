/**  版本信息模板在安装目录下，可自行修改。
* Dormitory.cs
*
* 功 能： N/A
* 类 名： Dormitory
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018-01-02 22:07:07   N/A    初版
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
	/// Dormitory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Dormitory
	{
		public Dormitory()
		{}
		#region Model
		private string _flo_num;
		private string _dor_num;
		private int _num_occupants;
		private int _live_num;
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
		public int num_occupants
		{
			set{ _num_occupants=value;}
			get{return _num_occupants;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int live_num
		{
			set{ _live_num=value;}
			get{return _live_num;}
		}
		#endregion Model

	}
}


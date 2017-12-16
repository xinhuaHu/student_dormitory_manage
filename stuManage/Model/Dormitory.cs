﻿using System;
namespace stuManage.Model
{
	/// <summary>
	/// Dormitory:实体类(属性说明自动提取数据库字段的描述信息)
    /// 宿舍表
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
		/// 楼号
		/// </summary>
		public string flo_num
		{
			set{ _flo_num=value;}
			get{return _flo_num;}
		}
		/// <summary>
		/// 宿舍号
		/// </summary>
		public string dor_num
		{
			set{ _dor_num=value;}
			get{return _dor_num;}
		}
		/// <summary>
        /// 已住人数
		/// </summary>
		public int num_occupants
		{
			set{ _num_occupants=value;}
			get{return _num_occupants;}
		}
		/// <summary>
		/// 可住人数
		/// </summary>
		public int live_num
		{
			set{ _live_num=value;}
			get{return _live_num;}
		}
		#endregion Model

	}
}


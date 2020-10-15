using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace STMOS.Models
{
    /// <summary>
    /// 学生表
    /// </summary>
    public class Student:BaseModel
    {
        /// <summary>
        /// 学号
        /// </summary>
        public string S_Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string S_name { get; set; }
        /// <summary>
        /// 父亲
        /// </summary>
        public string S_Father { get; set; }
        /// <summary>
        /// 母亲
        /// </summary>
        public string S_Mather { get; set; }
        /// <summary>
        /// 年级
        /// </summary>
        public string S_Grade { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int S_Age { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime S_BirthDate { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string S_Gender { get; set; }

    }
}

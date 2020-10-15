using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace STMOS.Models
{
    /// <summary>
    /// 老师表
    /// </summary>
    public class Teacher  : BaseModel
        {
            /// <summary>
            /// 老师ID号
            /// </summary>
            public string T_Id { get; set; }
            /// <summary>
            /// 姓名
            /// </summary>
            public string T_name { get; set; }
            /// <summary>
            /// 年龄
            /// </summary>
            public int T_Age { get; set; }
            /// <summary>
            /// 出生日期
            /// </summary>
            [DataType(DataType.Date)]
            public DateTime T_BirthDate { get; set; }
            /// <summary>
            /// 职称
            /// </summary>
            public string T_Level { get; set; }
            /// <summary>
            /// 性别
            /// </summary>
            public string T_Gender { get; set; }
     }
    
}

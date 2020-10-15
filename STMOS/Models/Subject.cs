using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace STMOS.Models
{
    /// <summary>
    /// 学科
    /// </summary>
    public class Subject:BaseModel
    {
        /// <summary>
        /// 学科ID
        /// </summary>
        public string SJ_Id { get; set; }
        /// <summary>
        /// 学科名称
        /// </summary>
        public string SJ_Name { get; set; }
        /// <summary>
        /// 授课老师
        /// </summary>
        public string SJ_TeacherName { get; set; }
    }
}

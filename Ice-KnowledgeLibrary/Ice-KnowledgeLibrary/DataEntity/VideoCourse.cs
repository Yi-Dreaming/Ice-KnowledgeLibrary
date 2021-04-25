using Magicodes.ExporterAndImporter.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FreeSql.DataAnnotations;

namespace Ice_KnowledgeLibrary.DataEntity
{
    /// <summary>
    /// 视频课程，代表一个视频集，如B站上刘铁猛的《C#入门教程》共40集。
    /// </summary>
    public class VideoCourse
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public int CourseId { get; set; }

        /// <summary>
        ///     课程名称
        /// </summary>
        [ImporterHeader(Name = "课程名称")]
        [ExporterHeader(DisplayName = "课程名称")]
        [Required(ErrorMessage = "名称不能为空")]
        public string Name { get; set; }

        /// <summary>
        ///     课程名称
        /// </summary>
        [ImporterHeader(Name = "视频个数")]
        [ExporterHeader(DisplayName = "视频个数")]
        [Required(ErrorMessage = "个数不能为空")]
        public long Count { get; set; }

        /// <summary>
        ///     课程进度
        /// </summary>
        [ImporterHeader(Name = "课程进度")]
        [ExporterHeader(DisplayName = "课程进度")]
        [Required(ErrorMessage = "进度不能为空")]
        public string Progress{ get; set; }


    }
}

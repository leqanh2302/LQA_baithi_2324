using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LQA_BaiThi2324.Model
{
    [Table("Student")]
    public class Student:Person
    {
        public int msv { get; set; }
        public string hoten { get; set; }


    }
    

}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LQA_BaiThi2324.Model

{
    public class Person{
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double tuoi { get; set; }
    }
}



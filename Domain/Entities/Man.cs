using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Man 
    {
        public string Id { get; set; }
        [Display(Name = "Предварительный диагноз")]  
        public string PreliminaryDiagnosis { get; set; }
        [Display(Name = "ТNM")]  
        public string TNM { get; set; }
        [Display(Name = "Гистологическое исследование опухоли")]  
        public string HistologicalAnalysis { get; set; }
        [Display(Name = "Наследственные мутации")]  
        public string HereditaryMutations { get; set; }
        [Display(Name = "Сопутствующие диагнозы")]  
        public string ConcomitantDiagnoses { get; set; }
        [Display(Name = "Планируемое онкологическое лечение")]  
        public string PlannedTreatment { get; set; } 
        
        [Display(Name = "Результаты ПЦР на ИППП")]  
        public string SexualInfections { get; set; }
        [Display(Name = "Анализ секрета")]  
        public string SecretAnalysis { get; set; }
        [Display(Name = "Спермограмма")]  
        public string Spermogram { get; set; }
        [Display(Name = "Дата криоконсервации спермы")]  
        public DateTime SemenCryoDate { get; set; }
        [Display(Name = "Порции криоконсервации")]  
        public string CryoPortions { get; set; }
        [Display(Name = "Программа")]  
        public string Program { get; set; }
        [Display(Name = "Возвращение за реализацией")]  
        public string ReturnForRealization { get; set; }
        [Display(Name = "Программа ВРТ")]  
        public string VRTProgram { get; set; }
        [Display(Name = "Исход")]  
        public string Result { get; set; }

        
        public string PatientId { get; set; }
    }
}
 
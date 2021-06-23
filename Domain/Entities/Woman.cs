using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Woman 
    {   
        public Guid Id { get; set; }
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
        [Display(Name = "Менархе")]  
        public string Menarche { get; set; }
        [Display(Name = "Менструация (по/через/обильность/болезненность)")]  
        public string Menstruation { get; set; }
        [Display(Name = "Последняя менструация")]  
        public DateTime LastMenstruation { get; set; }
        [Display(Name = "Беременностей")]  
        public int Pregnancies { get; set; }
        [Display(Name = "Роды")]  
        public int Births { get; set; }
        [Display(Name = "Аборты")]  
        public int Abortions { get; set; }
        [Display(Name = "Самопроизвольные выкидыши/на сроке")]  
        public string Miscarriages { get; set; }
        [Display(Name = "Гинекологические заболевания")]  
        public string GynecologicalDiseases { get; set; }
        [Display(Name = "Результаты ПЦР на ИППП")]  
        public string SexualInfections { get; set; }
        [Display(Name = "Мазок на флору")]  
        public string Flora { get; set; }
        [Display(Name = "АМГ")]  
        public double AMG { get; set; }
        [Display(Name = "ФСГ")]  
        public double FSG { get; set; }
        [Display(Name = "Эстрадиол")]  
        public double Estradiol { get; set; }
        [Display(Name = "Тестостерон")]  
        public double Testosterone { get; set; }
        [Display(Name = "Пролактин")]  
        public double Prolactin { get; set; }
        [Display(Name = "ТТГ")]  
        public double TTG { get; set; }
        [Display(Name = "УЗИ: размеры матки, толщина эндометрия, количество фолликулов")]  
        public string Ultrasound { get; set; }
        [Display(Name = "Прогнозируемы ответ яичников на стимуляцию")]  
        public string PredictedResponse { get; set; }
        [Display(Name = "Дата начала стимуляции")]  
        public DateTime StimulationStart { get; set; }
        [Display(Name = "День менструального цикла")]  
        public int DayOfCycle { get; set; }
        [Display(Name = "Программа")]  
        public double Program { get; set; }
        [Display(Name = "Протокол стимуляции (препараты)")]  
        public string StimulationProtocol { get; set; }
        [Display(Name = "Препараты / доза")]  
        public string Preparates { get; set; }
        [Display(Name = "Количество дней стимуляции")]  
        public int StimulationDurationInDays { get; set; }
        [Display(Name = "Триггер овуляции")]  
        public string OvulationTrigger { get; set; }
        [Display(Name = "День ТВП")]  
        public DateTime TVPDay { get; set; }
        [Display(Name = "Получено ооцитов (количество)")]  
        public double OocytesReceived { get; set; }
        [Display(Name = "Получено ооцитов (зрелость)")]  
        public string OocytesQuality { get; set; }
        [Display(Name = "Программа оплодотворения")]  
        public string FertilizationProgram { get; set; }
        [Display(Name = "Количество эмбрионов")]  
        public double NumberOfEmbryos { get; set; }
        [Display(Name = "ПГТ - А")]  
        public double PGTA { get; set; } 
        [Display(Name = "Криоконсервировано ооцитов (количество)")]  
        public string CryopreservedOocytes { get; set; }
        [Display(Name = "Оплодотворено ооцитов")]  
        public double OocytesFertilized { get; set; }
        [Display(Name = "Криоконсерваровано эмбрионов (качество)")]  
        public string CryopreservedEmbryosQuality { get; set; }
        [Display(Name = "Криоконсерваровано эмбрионов (количество)")]  
        public double CryopreservedEmbryosQuantity { get; set; }
        [Display(Name = "Обращение за реализацией")]
        public string RealizationRequest { get; set;}
        [Display(Name = "Количество расконсервировано")]
        public double QuantityUnserved { get; set; }
        [Display(Name = "Подготовка эндометрия (ЗГТ\\ЕЦ\\суррогатное материнство)")]
        public string EndometrialPreparation { get; set; }
        [Display(Name = "Толщина эндометрия на день назначения триггера овуляции")]
        public double EndometrialThicknessTriggerDay { get; set; }
        [Display(Name = "Толщина эндометрия на день подсадки")]
        public double EndometrialThicknessImplantationDay { get; set; }
        [Display(Name = "Дата (день) подсадки")]
        public DateTime ImplantationDay { get; set; }
        [Display(Name = "Качество эмбриона")]
        public string EmbryoQuality { get; set; }
        [Display(Name = "Количество эмбриона")]
        public double EmbryoQuantity { get; set; }
        [Display(Name = "ХГЧ на 11-12 день после переноса")]
        public double HChGOnTransferDay { get; set; }
        [Display(Name = "Биохимическая беременность")]
        public string BiochemicalPregnancy { get; set; }
        [Display(Name = "Клиническая беременность")]
        public string ClinicalPregnancy { get; set; }
        [Display(Name = "Отрицательный результат")]
        public string NegativeResult { get; set; }
        [Display(Name = "Исход")]
        public string Result { get; set; }
        [Display(Name = "Акушерские осложнения")]
        public string ObstetricComplications { get; set; }
        [Display(Name = "Срок беременности на момент родоразрешения")]
        public int PregnancyDurationOnBirthDate { get; set; }
        [Display(Name = "Способ родоразрешения")]
        public string BirthMethod { get; set; }

        public string PatientId { get; set; }
    }
}
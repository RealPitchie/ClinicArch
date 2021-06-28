using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    SurName = table.Column<string>(type: "text", nullable: true),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Age = table.Column<decimal>(type: "numeric", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<decimal>(type: "numeric", nullable: false),
                    Height = table.Column<decimal>(type: "numeric", nullable: false),
                    BadHabits = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenStats",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    PreliminaryDiagnosis = table.Column<string>(type: "text", nullable: true),
                    TNM = table.Column<string>(type: "text", nullable: true),
                    HistologicalAnalysis = table.Column<string>(type: "text", nullable: true),
                    HereditaryMutations = table.Column<string>(type: "text", nullable: true),
                    ConcomitantDiagnoses = table.Column<string>(type: "text", nullable: true),
                    PlannedTreatment = table.Column<string>(type: "text", nullable: true),
                    SexualInfections = table.Column<string>(type: "text", nullable: true),
                    SecretAnalysis = table.Column<string>(type: "text", nullable: true),
                    Spermogram = table.Column<string>(type: "text", nullable: true),
                    SemenCryoDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CryoPortions = table.Column<string>(type: "text", nullable: true),
                    Program = table.Column<string>(type: "text", nullable: true),
                    ReturnForRealization = table.Column<string>(type: "text", nullable: true),
                    VRTProgram = table.Column<string>(type: "text", nullable: true),
                    Result = table.Column<string>(type: "text", nullable: true),
                    PatientId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenStats_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WomenStats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PreliminaryDiagnosis = table.Column<string>(type: "text", nullable: true),
                    TNM = table.Column<string>(type: "text", nullable: true),
                    HistologicalAnalysis = table.Column<string>(type: "text", nullable: true),
                    HereditaryMutations = table.Column<string>(type: "text", nullable: true),
                    ConcomitantDiagnoses = table.Column<string>(type: "text", nullable: true),
                    PlannedTreatment = table.Column<string>(type: "text", nullable: true),
                    Menarche = table.Column<string>(type: "text", nullable: true),
                    Menstruation = table.Column<string>(type: "text", nullable: true),
                    LastMenstruation = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Pregnancies = table.Column<int>(type: "integer", nullable: false),
                    Births = table.Column<int>(type: "integer", nullable: false),
                    Abortions = table.Column<int>(type: "integer", nullable: false),
                    Miscarriages = table.Column<string>(type: "text", nullable: true),
                    GynecologicalDiseases = table.Column<string>(type: "text", nullable: true),
                    SexualInfections = table.Column<string>(type: "text", nullable: true),
                    Flora = table.Column<string>(type: "text", nullable: true),
                    AMG = table.Column<double>(type: "double precision", nullable: false),
                    FSG = table.Column<double>(type: "double precision", nullable: false),
                    Estradiol = table.Column<double>(type: "double precision", nullable: false),
                    Testosterone = table.Column<double>(type: "double precision", nullable: false),
                    Prolactin = table.Column<double>(type: "double precision", nullable: false),
                    TTG = table.Column<double>(type: "double precision", nullable: false),
                    Ultrasound = table.Column<string>(type: "text", nullable: true),
                    PredictedResponse = table.Column<string>(type: "text", nullable: true),
                    StimulationStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DayOfCycle = table.Column<int>(type: "integer", nullable: false),
                    Program = table.Column<double>(type: "double precision", nullable: false),
                    StimulationProtocol = table.Column<string>(type: "text", nullable: true),
                    Preparates = table.Column<string>(type: "text", nullable: true),
                    StimulationDurationInDays = table.Column<int>(type: "integer", nullable: false),
                    OvulationTrigger = table.Column<string>(type: "text", nullable: true),
                    TVPDay = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    OocytesReceived = table.Column<double>(type: "double precision", nullable: false),
                    FertilizationProgram = table.Column<string>(type: "text", nullable: true),
                    NumberOfEmbryos = table.Column<double>(type: "double precision", nullable: false),
                    PGTA = table.Column<double>(type: "double precision", nullable: false),
                    CryopreservedOocytes = table.Column<string>(type: "text", nullable: true),
                    OocytesFertilized = table.Column<double>(type: "double precision", nullable: true),
                    OocytesQuality = table.Column<string>(type: "text", nullable: false),
                    CryopreservedEmbryosQuality = table.Column<string>(type: "text", nullable: true),
                    CryopreservedEmbryosQuantity = table.Column<double>(type: "double precision", nullable: false),
                    RealizationRequest = table.Column<string>(type: "text", nullable: true),
                    QuantityUnserved = table.Column<double>(type: "double precision", nullable: false),
                    EndometrialPreparation = table.Column<string>(type: "text", nullable: true),
                    EndometrialThicknessTriggerDay = table.Column<double>(type: "double precision", nullable: false),
                    EndometrialThicknessImplantationDay = table.Column<double>(type: "double precision", nullable: false),
                    ImplantationDay = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EmbryoQuality = table.Column<string>(type: "text", nullable: true),
                    EmbryoQuantity = table.Column<double>(type: "double precision", nullable: false),
                    HChGOnTransferDay = table.Column<double>(type: "double precision", nullable: false),
                    BiochemicalPregnancy = table.Column<string>(type: "text", nullable: true),
                    ClinicalPregnancy = table.Column<string>(type: "text", nullable: true),
                    NegativeResult = table.Column<string>(type: "text", nullable: true),
                    Result = table.Column<string>(type: "text", nullable: true),
                    ObstetricComplications = table.Column<string>(type: "text", nullable: true),
                    PregnancyDurationOnBirthDate = table.Column<int>(type: "integer", nullable: false),
                    BirthMethod = table.Column<string>(type: "text", nullable: true),
                    PatientId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WomenStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WomenStats_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenStats_PatientId",
                table: "MenStats",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WomenStats_PatientId",
                table: "WomenStats",
                column: "PatientId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenStats");

            migrationBuilder.DropTable(
                name: "WomenStats");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}

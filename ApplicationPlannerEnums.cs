namespace AmsModels;

public enum ApplicationTriggerType
{
    Calendar = 0,
    GddDeviation = 1,
    HeatStress = 2,
    DiseaseRisk = 3,
    SoilMoisture = 4
}

public enum ApplicationProductCategory
{
    Unknown = 0,
    Fertilizer = 1,
    Fungicide = 2,
    WettingAgent = 3,
    Pgr = 4,
    Herbicide = 5,
    Insecticide = 6,
    Biostimulant = 7,
    Other = 99
}

public enum ApplicationValidationStatus
{
    Draft = 0,
    PendingValidation = 1,
    Valid = 2,
    Warning = 3,
    Blocked = 4
}

public enum ApplicationPlanRevisionStatus
{
    Draft = 0,
    Approved = 1,
    Superseded = 2
}

public enum ApplicationPlanItemScheduleStatus
{
    Planned = 0,
    Postponed = 1,
    Skipped = 2
}

public enum ApplicationPlanItemScheduleEventType
{
    Postponed = 1,
    Skipped = 2,
    Reopened = 3
}

public enum ApplicationPlanItemScheduleReason
{
    Weather = 1,
    SurfaceUnavailable = 2,
    ProductUnavailable = 3,
    EquipmentUnavailable = 4,
    Staffing = 5,
    GrowthConditions = 6,
    AgronomicDecision = 7,
    ReplacedByAnotherApplication = 8,
    Correction = 9,
    Other = 99
}

public enum ApplicationTriggerSeverity
{
    Info = 0,
    Low = 1,
    Moderate = 2,
    High = 3,
    Critical = 4
}

public enum PlanTriggerStatus
{
    Suggested = 0,
    Approved = 1,
    Dismissed = 2,
    Applied = 3
}

public enum PlanDeviationType
{
    Delayed = 0,
    Skipped = 1,
    Reduced = 2,
    Replaced = 3,
    Added = 4
}

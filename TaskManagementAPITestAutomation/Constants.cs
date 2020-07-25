using System;

namespace TaskManagementAPITestAutomation
{
    public static class Constants
    {
        public static string clearTable = "Delete from ";
        public static string populateMultipleProjectRecords = "Insert into Projects(Name) values('Load Testing'),('Mobile Testing')";
        public static string retrieveRecordFromProjectTable = "Select * from Projects";
        public static string retrieveNameColumnFromProjectTable = "Select Name from Projects";
        public static string populateSingleProjectTRecord = "Insert into Projects(Name) values('Load Testing')";
        public static string retrieveIdColumnFromProjectTable = "Select Id from Projects";
    }
}

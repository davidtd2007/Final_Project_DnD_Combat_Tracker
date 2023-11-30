namespace dnd
{
    class Constants
    {
        //sql queries

        //Campaing related queries


        public static string GET_ALL_CAMPAING = "SELECT * FROM Campaing";
        public static string SAVE_NEW_CAMPAING = "INSERT INTO Campaing (name,description) VALUES (@name, @description)";
        public static string GET_CAMPAING_NAME_BY_ID = "SELECT name FROM Campaing WHERE id=@id";
        public static string GET_CAMPAING_INFO_FROM_ID = "SELECT * FROM Campaing WHERE id=@id";
        public static string UPDATE_CAMPAING_INFO = "UPDATE Campaing SET name=@name, description=@description WHERE id=@id";
        public static string DELETE_CAMPAIGN = "DELETE Campaing WHERE id=@id";



        //Character management related queries

        public static string SAVE_NEW_CHARACTER = "INSERT INTO Characters (specie,Campaing_ID,HP,name,IB,AC) VALUES (@specie,@Campaing_ID,@HP,@name,@IB,@AC)";
        public static string GET_CHARACTER_NAME_FROM_ID = "SELECT Name FROM Characters WHERE Id=@id";
        public static string GET_CHARACTER_INFO_FROM_ID = "SELECT * FROM Characters WHERE Id=@id";
        public static string GET_CHARACTER_INFO_FROM_CAMPAING_ID = "SELECT * FROM Characters WHERE Campaing_ID=@id";
        public static string UPDATE_CHARACTER_INFO = "UPDATE Characters SET Name=@name, HP=@HP, AC=@AC ,IB=@IB, Specie=@Specie WHERE id=@id";
        public static string GET_CHARACTER_ID_FROM_CAMPAING_ID = "SELECT Id FROM Characters WHERE Campaing_ID=@id";
        public static string GET_CHARACTER_NAME_AND_ID_FROM_CAMPAING_ID = "SELECT Id, name FROM Characters WHERE Campaing_ID=@id";
        public static string DELETE_CHARCTER = "DELETE Characters WHERE id=@id";
      
        //Class management relates queries

        public static string GET_CHARACTER_LEVEL = "SELECT class_level FROM Character_Class WHERE character_ID=@id";
        public static string GET_CHARACTER_LEVEL_AND_ID = "SELECT id,class_level FROM Character_Class WHERE character_ID=@id";
        public static string SAVE_NEW_CLASS = "INSERT INTO Character_Class (class_name,class_level,character_ID,subclass) VALUES (@class_name, @class_level,@character_ID,@subclass)";
        public static string GET_CHARACTER_CLASS_FROM_CHARACTER_ID = "SELECT * FROM Character_Class WHERE character_ID=@id";
        public static string GET_CLASS_INFO_FROM_ID = "SELECT * FROM Character_Class WHERE id=@id";
        public static string UPDATE_CLASS_INFO = "UPDATE Character_Class SET class_name=@class_name, subclass=@subclass, class_level=@class_level WHERE id=@id";
        public static string DELETE_CLASS = "DELETE Character_CLass WHERE id=@id";
        public static string DELETE_CLASS_FROM_CHARACTER = "DELETE Character_CLass WHERE Character_Id=@id";

        //Monster management relates queries
        public static string SAVE_NEW_MONSTER = "INSERT INTO Monsters (CR,HP,name,IB,AC,statblock) VALUES (@CR,@HP,@name,@IB,@AC,@statblock)";
        public static string GET_ALL_MONSTER_DATA = "SELECT id,name,CR FROM Monsters";
        public static string GET_MONSTER_INFO_FROM_ID = "SELECT * FROM Monsters WHERE id=@id";
        public static string UPDATE_MONSTER = "UPDATE Monsters SET Name = @name, HP = @HP, AC = @AC, IB = @IB, CR=@CR, statblock=@statblock WHERE id = @id";
        public static string GET_MONSTER_STATBLOCK_FROM_ID = "SELECT statblock FROM Monsters WHERE Id=@id";
        public static string GET_MONSTER_NAME_FROM_ID = "SELECT name FROM Monsters WHERE Id=@id";

        //Encounter management related queries

        public static string SAVE_NEW_ENCOUNTER = "INSERT INTO Encounter (name,description,turn,round,Campaing_id,difficulty) VALUES (@name,@description,@turn,@round,@campaing_id,@difficulty)";
        public static string GET_ALL_ENCOUNTER_ID = "SELECT Id FROM Encounter";
        public static string GET__ENCOUNTER_ID_FROM_CAMPAIGN_ID = "SELECT Id FROM Encounter WHERE Campaing_id=@id";
        public static string SAVE_NEW_MONSTER_LIST = "INSERT INTO Monster_List(Encounter_ID,Monster_ID) VALUES(@Encounter_ID,@Monster_ID)";
        public static string GET_ENCOUNTER_NAME__AND_DIFFICULTY_AND_ID_FROM_CAMPAING_ID = "SELECT id,name,difficulty FROM Encounter WHERE Campaing_Id = @id";
        public static string SAVE_NEW_INIT_CHARACTER = "INSERT INTO Initiative_Count(Initiative,Encounter_ID,Character_Id,Current_HP) VALUES(@Initiative,@Encounter_ID,@Character_Id,@Current_HP)";
        public static string GET_INITIAITVE_ID_FROM_ENCOUNTER = "SELECT Initiative FROM Initiative_Count WHERE Encounter_ID = @id";
        public static string GET_MONSTER_ID_FROM_ENCOUNTER = "SELECT Monster_Id FROM Monster_List WHERE Encounter_ID=@id";
        public static string SAVE_NEW_INIT_MONSTER = "INSERT INTO Initiative_Count(Initiative,Encounter_ID,Monster_Id,Current_HP) VALUES(@Initiative,@Encounter_ID,@Monster_Id,@Current_HP)";
        public static string GET_MONSTER_INFO_FROM_INTITIATIVE = "SELECT Monster_Id , Current_HP,id FROM Initiative_Count WHERE Initiative=@Initiative AND Encounter_ID =@Encounter_ID";
        public static string GET_CHARACTER_INFO_FROM_INTITIATIVE = "SELECT Character_Id , Current_HP,id FROM Initiative_Count WHERE Initiative=@Initiative AND Encounter_ID =@Encounter_ID";
        public static string GET_ENCOUNTER_INFO_FROM_ID = "SELECT * FROM Encounter WHERE id=@id";
        public static string UPDATE_INI_COUNT = "UPDATE Initiative_Count SET Current_HP=@Current_HP WHERE id=@id";
        public static string UPDATE_ENCOUNTER = "UPDATE Encounter SET turn=@turn, round=@round WHERE id=@id";
        public static string DELETE_INI_COUNT = "DELETE Initiative_Count WHERE Encounter_Id=@id";
        public static string DELETE_MONSTER_LIST = "DELETE Monster_List WHERE Encounter_Id=@id";
        public static string DELETE_ENCOUNTER = "DELETE Encounter WHERE id=@id";
        public static string DELETE_INI_COUNT_CHA = "DELETE Initiative_Count WHERE Character_Id=@id";
        




        //Condition Management related queries
        public static string GET_CONDITON_NAMES = "SELECT name FROM Condition";
        public static string GET_CONDITON_NAME_AND_DESCRIPTION = "SELECT name,effect FROM Condition WHERE id=@id";
        public static string GET_CONDITON_ID_AND_NAME = "SELECT id,name FROM Condition";
        public static string SAVE_NEW_CONDITION_CHARACTER = "INSERT INTO Status (Duration_Type,Duration_Time,Encounter_ID,Character_Id,Condition_ID) VALUES(@Duration_Type,@Duration_Time,@Encounter_ID,@Character_Id,@Condition_ID)";
        public static string SAVE_NEW_CONDITION_MONSTER = "INSERT INTO Status (Duration_Type,Duration_Time,Encounter_ID,Monster_Id,Condition_ID) VALUES(@Duration_Type,@Duration_Time,@Encounter_ID,@Monster_Id,@Condition_ID)";
        public static string GET_CONDITON_ID_FROM_NAME = "SELECT id FROM Condition WHERE name=@name";
        public static string GET_CONDITON_NAME_FROM_ID = "SELECT name FROM Condition WHERE id=@id";
        public static string GET_STATUS_FROM_ENCOUNTER_ID = "SELECT * FROM Status WHERE Encounter_ID=@id";
        public static string DELETE_STATUS = "DELETE Status WHERE id=@id";
        public static string DELETE_STATUS_USING_ECNOUNTER_ID = "DELETE Status WHERE Encounter_Id=@id";
        public static string DELETE_STATUS_USING_CHARACTER_ID = "DELETE Status WHERE Character_Id=@id";
        public static string UPDATE_CONDITION = "UPDATE Status SET Duration_Time=@Duration_Time, Duration_Type=@Duration_Type WHERE id=@id";


        //Rules management related queries

        public static string GET_RULE_NAME_AND_DESCRIPTION = "SELECT name,description FROM Rules WHERE id=@id";
        public static string GET_RULE_ID_AND_NAME = "SELECT id,name FROM Rules";
    }
}

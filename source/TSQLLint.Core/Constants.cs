using System.Collections.Generic;

namespace TSQLLint.Core
{
    public static class Constants
    {
        public static readonly string[] _TSqlKeywords =
        {
            "ADD",
            "ALL",
            "ALTER",
            "AND",
            "ANY",
            "AS",
            "ASC",
            "AUTHORIZATION",
            "BACKUP",
            "BEGIN",
            "BETWEEN",
            "BREAK",
            "BROWSE",
            "BULK",
            "BY",
            "CASCADE",
            "CASE",
            "CHECK",
            "CHECKPOINT",
            "CLOSE",
            "CLUSTERED",
            "COALESCE",
            "COLLATE",
            "COLUMN",
            "COMMIT",
            "COMPUTE",
            "CONSTRAINT",
            "CONTAINS",
            "CONTAINSTABLE",
            "CONTINUE",
            "CONVERT",
            "CREATE",
            "CROSS",
            "CURRENT",
            "CURRENT_DATE",
            "CURRENT_TIME",
            "CURRENT_TIMESTAMP",
            "CURRENT_USER",
            "CURSOR",
            "DATABASE",
            "DBCC",
            "DEALLOCATE",
            "DECLARE",
            "DEFAULT",
            "DELETE",
            "DENY",
            "DESC",
            "DISK",
            "DISTINCT",
            "DISTRIBUTED",
            "DOUBLE",
            "DROP",
            "DUMP",
            "ELSE",
            "END",
            "ERRLVL",
            "ESCAPE",
            "EXCEPT",
            "EXEC",
            "EXECUTE",
            "EXISTS",
            "EXIT",
            "EXTERNAL",
            "FETCH",
            "FILE",
            "FILLFACTOR",
            "FOR",
            "FOREIGN",
            "FREETEXT",
            "FREETEXTTABLE",
            "FROM",
            "FULL",
            "FUNCTION",
            "GOTO",
            "GRANT",
            "GROUP",
            "HAVING",
            "HOLDLOCK",
            "IDENTITY",
            "IDENTITYCOL",
            "IDENTITY_INSERT",
            "IF",
            "IN",
            "INDEX",
            "INNER",
            "INSERT",
            "INTERSECT",
            "INTO",
            "IS",
            "JOIN",
            "KEY",
            "KILL",
            "LEFT",
            "LIKE",
            "LINENO",
            "LOAD",
            "MERGE",
            "NATIONAL",
            "NOCHECK",
            "NONCLUSTERED",
            "NOT",
            "NULL",
            "NULLIF",
            "OF",
            "OFF",
            "OFFSETS",
            "ON",
            "OPEN",
            "OPENDATASOURCE",
            "OPENQUERY",
            "OPENROWSET",
            "OPENXML",
            "OPTION",
            "OR",
            "ORDER",
            "OUTER",
            "OVER",
            "PERCENT",
            "PIVOT",
            "PLAN",
            "PRECISION",
            "PRIMARY",
            "PRINT",
            "PROC",
            "PROCEDURE",
            "PUBLIC",
            "RAISERROR",
            "READ",
            "READTEXT",
            "RECONFIGURE",
            "REFERENCES",
            "REPLICATION",
            "RESTORE",
            "RESTRICT",
            "RETURN",
            "REVERT",
            "REVOKE",
            "RIGHT",
            "ROLLBACK",
            "ROWCOUNT",
            "ROWGUIDCOL",
            "RULE",
            "SAVE",
            "SCHEMA",
            "SECURITYAUDIT",
            "SELECT",
            "SEMANTICKEYPHRASETABLE",
            "SEMANTICSIMILARITYDETAILSTABLE",
            "SEMANTICSIMILARITYTABLE",
            "SESSION_USER",
            "SET",
            "SETUSER",
            "SHUTDOWN",
            "SOME",
            "STATISTICS",
            "SYSTEM_USER",
            "TABLE",
            "TABLESAMPLE",
            "TEXTSIZE",
            "THEN",
            "TO",
            "TOP",
            "TRAN",
            "TRANSACTION",
            "TRIGGER",
            "TRUNCATE",
            "TRY_CONVERT",
            "TSEQUAL",
            "UNION",
            "UNIQUE",
            "UNPIVOT",
            "UPDATE",
            "UPDATETEXT",
            "USE",
            "USER",
            "VALUES",
            "VARYING",
            "VIEW",
            "WAITFOR",
            "WHEN",
            "WHERE",
            "WHILE",
            "WITH",
            "WITHIN GROUP",
            "WRITETEXT"
        };

        public static readonly string[] _TSqlDataTypes =
        {
            "BIGINT",
            "BIT",
            "DECIMAL",
            "INT",
            "MONEY",
            "NUMERIC",
            "SMALLINT",
            "SMALLMONEY",
            "TINYINT",
            "FLOAT",
            "REAL",
            "DATE",
            "DATETIME2",
            "DATETIME",
            "DATETIMEOFFSET",
            "SMALLDATETIME",
            "TIME",
            "CHAR",
            "TEXT",
            "VARCHAR",
            "NCHAR",
            "NTEXT",
            "NVARCHAR",
            "BINARY",
            "IMAGE",
            "VARBINARY",
            "CURSOR",
            "ROWVERSION",
            "UNIQUEIDENTIFIER",
            "XML"
        };

        public static readonly HashSet<string> TSqlKeywords = new HashSet<string>(_TSqlKeywords);

        public static readonly HashSet<string> TSqlDataTypes = new HashSet<string>(_TSqlDataTypes);

        public static int TabWidth => 4;

        public static int DefaultCompatabilityLevel => 120;

        public static int MaxLineWidthForRegexEval => 300;
    }
}

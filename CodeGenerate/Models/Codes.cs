using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.SqlServer.Server;
using static CodeGenerate.Models.ApplicationDbContext;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System;

namespace CodeGenerate.Models
{
    public class Codes
    {

        public int Id { get; set; }
        public string Name { get; set; }


        //        create table GeneratedCode
        //(
        //Id int identity(1,1) primary key,
        //CompanyId int,
        //companyName varchar(100),
        //productId numeric,
        //productName varchar(100),
        //Code varchar(13) unique
        //)

        //procedure 


//        CREATE PROCEDURE GenerateSequentialCodes
//        @NumberOfCodes INT,
//    @CompanyId INT,
//    @ProductId INT
//AS
//BEGIN
//    DECLARE @LastCode INT, @NewCode INT, @Counter INT;
    
//    -- Get the last used code number from the database(or 0 if no codes exist)
//    SELECT @LastCode = MAX(CAST(SUBSTRING(Code, 5, 7) AS INT))
//    FROM GeneratedCode
//    WHERE Code LIKE FORMAT(@CompanyId, '00') + FORMAT(@ProductId, '00') + '-%';
    
//    IF @LastCode IS NULL
//    BEGIN
//        SET @LastCode = 0;  -- If no code exists yet, start from 0
//    END

//    -- Initialize the counter
//        SET @Counter = 1;

//    -- Loop to generate and insert codes
//    WHILE @Counter <= @NumberOfCodes
//    BEGIN
//        SET @NewCode = @LastCode + @Counter;
        
//        -- Format the new code
//        DECLARE @GeneratedCode VARCHAR(20);
//        SET @GeneratedCode = FORMAT(@CompanyId, '00') + FORMAT(@ProductId, '00') + '-' + RIGHT('0000000' + CAST(@NewCode AS VARCHAR(7)), 7);
        
//        -- Insert the new generated code into the table
//        INSERT INTO GeneratedCode(CompanyId, CompanyName, ProductId, ProductName, Code)
//        VALUES
//        (
//            @CompanyId,         -- CompanyId
//            'Example Company',  -- CompanyName (replace with actual value)
//            @ProductId,         -- ProductId
//            'Example Product',  -- ProductName(replace with actual value)
//            @GeneratedCode      -- Generated code in the desired format
//        );
        
//        SET @Counter = @Counter + 1;
//        END
//    END;


    }
}

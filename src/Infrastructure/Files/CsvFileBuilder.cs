﻿using System.Globalization;
using VerseChallenge.Application.Common.Interfaces;
using VerseChallenge.Application.TodoLists.Queries.ExportTodos;
using VerseChallenge.Infrastructure.Files.Maps;
using CsvHelper;

namespace VerseChallenge.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}

using System.Runtime.Serialization;
using AutoMapper;
using NUnit.Framework;
using VerseChallenge.Application.Common.Mappings;
using VerseChallenge.Application.TodoLists.Queries.GetTodos;
using VerseChallenge.Domain.Entities;

namespace VerseChallenge.Application.UnitTests.Common.Mappings;

public class MappingTests
{
    private readonly IConfigurationProvider _configuration;
    private readonly IMapper _mapper;

    public MappingTests()
    {
        _configuration = new MapperConfiguration(config =>
            config.AddProfile<MappingProfile>());

        _mapper = _configuration.CreateMapper();
    }

    [Test]
    public void ShouldHaveValidConfiguration()
    {
        _configuration.AssertConfigurationIsValid();
    }

    [Test]
    [TestCase(typeof(TodoList), typeof(TodoListDto))]
    [TestCase(typeof(TodoItem), typeof(TodoItemDto))]
    public void ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
    {
        object? instance = GetInstanceOf(source);

        _mapper.Map(instance, source, destination);
    }

    private object GetInstanceOf(Type type)
    {
        if (type.GetConstructor(Type.EmptyTypes) != null)
        {
            return Activator.CreateInstance(type)!;
        }

        // Type without parameterless constructor
        return FormatterServices.GetUninitializedObject(type);
    }
}

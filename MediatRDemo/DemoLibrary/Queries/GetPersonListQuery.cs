using DemoLibrary.Models;
using MediatR;
using System.Collections.Generic;

namespace DemoLibrary.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;

    //If you were to create a class, it would look like this:
    //public class GetPersonListQueryClass : IRequest<List<PersonModel>>
    //{
    //}
}
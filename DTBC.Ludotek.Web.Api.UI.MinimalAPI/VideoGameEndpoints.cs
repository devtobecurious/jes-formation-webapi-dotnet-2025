using DTBC.Ludotek.Core.VideoGames.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace DTBC.Ludotek.Web.Api.UI.MinimalAPI;

public static class VideoGameEndpoints
{
    public static void MapVideoGameEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/VideoGame").WithTags(nameof(VideoGame));

        group.MapGet("/", () =>
        {
            return new [] { new VideoGame() { Title = "" } };
        })
        .WithName("GetAllVideoGames")
        .WithOpenApi();

        group.MapGet("/{id}", (int id) =>
        {
            //return new VideoGame { ID = id };
        })
        .WithName("GetVideoGameById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, VideoGame input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdateVideoGame")
        .WithOpenApi();

        group.MapPost("/", (VideoGame model) =>
        {
            //return TypedResults.Created($"/api/VideoGames/{model.ID}", model);
        })
        .WithName("CreateVideoGame")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
            //return TypedResults.Ok(new VideoGame { ID = id });
        })
        .WithName("DeleteVideoGame")
        .WithOpenApi();
    }
}

using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

namespace myfirstbot
{
    [LuisModel("af8c83d6-e82d-4273-b539-3bfde06108a2", "b7de1eda300f4e99913d9eac7748d430")]
    [Serializable]
    public class MovieAppLuisDialog : LuisDialog<object>
    {
        [LuisIntent("")]
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult luisResult)
        {
            string message = "Sorry, I talk only movies. Try again";
            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("watch a movie")]
        public async Task WatchMovie(IDialogContext context, LuisResult luisResult)
        {
            string message = "I see you want to watch a movie";
            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("see a movie")]
        public async Task SeeMovie(IDialogContext context, LuisResult luisResult)
        {
            string message = "I see you want to see a movie";
            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("enjoy a movie")]
        public async Task EnjoyMovie(IDialogContext context, LuisResult luisResult)
        {
            string message = "I see you want to enjoy a movie";
            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("Pick a movie")]
        public async Task PickMovie(IDialogContext context, LuisResult luisResult)
        {
            string message = "I see you want to pick a movie";
            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("go for a movie")]
        public async Task GoMovie(IDialogContext context, LuisResult luisResult)
        {
            string message = "I see you want to go for a movie";
            await context.PostAsync(message);
            context.Wait(this.MessageReceived);
        }
    }
}
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Discord.Commands;
using DiscordBot.Common;

namespace DiscordBot.Modules
{
    public class TreeOfSaviorModule: ModuleBase<SocketCommandContext>
    {   
        ///<summary>
        ///this message
        ///</summary>
        [Command("help"), Alias("h")]
        public Task Help()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");

        ///<summary>
        ///greets he bot
        ///</summary>
        [Command("hello"), Alias("hi")]
        public Task Hello()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");

        ///<summary>
        ///get latest news/updates from Tree of Savior official website
        ///</summary>                
        [Command("news")]
        public Task News()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
                
        ///<summary>
        ///ping the bot
        ///</summary>                  
        [Command("ping")]
        public Task Ping()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
                 
        ///<summary>
        ///get link for ktest version of tos.neet
        ///</summary>                 
        [Command("ktest")]
        public Task KTest()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
                
        ///<summary>
        ///get link for latest data mined file(s)
        ///</summary>                  
        [Command("update")]
        public Task Update()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
                
        ///<summary>
        ///get link for class/build planner
        ///</summary>  
        [Command("planner")]
        public Task Planner()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
                
        ///<summary>
        ///get my invitation link
        ///</summary>  
        [Command("invite")]
        public Task Invite()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
                
        ///<summary>
        ///get tos's player statistics
        ///</summary>  
        [Command("pccu")]
        public Task PCCU()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
                
        ///<summary>
        ///get link for leveling guide
        ///</summary>  
        [Command("lv"), Alias("leveling")]
        public Task Level()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
                
        ///<summary>
        ///get class build rankings (based on itos official website)
        ///</summary>                  
        [Command("rank")]
        public Task Rank()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
                
        ///<summary>
        ///get link for explorer's gimmick & new collections guide 
        ///</summary>  
        [Command("explore")]
        public Task Explore()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
                
        ///<summary>
        ///get builds compilation docs
        ///</summary>  
        [Command("build")]
        public Task Build()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
                
        ///<summary>
        ///get hidden class/rank 8 class unlock guides docs
        ///</summary>  
        [Command("unlock")]
        public Task Unlock()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
                
        ///<summary>
        ///get reddit link for newbie/returning player discussion
        ///</summary>  
        [Command("faq")]
        public Task Fa()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
                
        ///<summary>
        ///get link to download latest addon manager
        ///</summary>  
        [Command("addon")]
        public Task AddOn()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
                
        ///<summary>
        ///get link for guide and class breakdown
        ///</summary>  
        [Command("get"), Alias("item")]
        public Task Get()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");
               
        ///<summary>
        ///get pastebin link for ktos/ktest patch notes translation from Greyhiem & Gwenyth.
        ///</summary>
        [Command("skill")]
        public Task Skill()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");

        [Command("test")]
        public Task Test()
            => ReplyAsync(
                $"{TreeOfSaviorHelper.GetCommandValue(TreeOfSaviorHelper.TrimCommandMessage(Context.Message.Content, Context.Client.CurrentUser.Mention))}");

    }
}
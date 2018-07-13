using System.Threading.Tasks;
using Discord.Commands;

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
                $"Coming soon for help command\n");

        ///<summary>
        ///greets he bot
        ///</summary>
        [Command("hello"), Alias("hi")]
        public Task Hello()
            => ReplyAsync(
                $"Coming soon for hello command\n");

        ///<summary>
        ///get latest news/updates from Tree of Savior official website
        ///</summary>                
        [Command("news")]
        public Task News()
            => ReplyAsync(
                $"Coming soon for news command\n");
                
        ///<summary>
        ///ping the bot
        ///</summary>                  
        [Command("ping")]
        public Task Ping()
            => ReplyAsync(
                $"Coming soon for ping command\n");
                 
        ///<summary>
        ///get link for ktest version of tos.neet
        ///</summary>                 
        [Command("ktest")]
        public Task KTest()
            => ReplyAsync(
                $"Coming soon for ktest command\n");
                
        ///<summary>
        ///get link for latest data mined file(s)
        ///</summary>                  
        [Command("update")]
        public Task Update()
            => ReplyAsync(
                $"Coming soon for update command\n");
                
        ///<summary>
        ///get link for class/build planner
        ///</summary>  
        [Command("planner")]
        public Task Planner()
            => ReplyAsync(
                $"Coming soon for planner command\n");
                
        ///<summary>
        ///get my invitation link
        ///</summary>  
        [Command("invite")]
        public Task Invite()
            => ReplyAsync(
                $"Coming soon for invite command\n");
                
        ///<summary>
        ///get tos's player statistics
        ///</summary>  
        [Command("pccu")]
        public Task PCCU()
            => ReplyAsync(
                $"Coming soon for pccu command\n");
                
        ///<summary>
        ///get link for leveling guide
        ///</summary>  
        [Command("lv")]
        public Task Level()
            => ReplyAsync(
                $"Coming soon for lv command\n");
                
        ///<summary>
        ///get class build rankings (based on itos official website)
        ///</summary>                  
        [Command("rank")]
        public Task Rank()
            => ReplyAsync(
                $"Coming soon for rank command\n");
                
        ///<summary>
        ///get link for explorer's gimmick & new collections guide 
        ///</summary>  
        [Command("explore")]
        public Task Explore()
            => ReplyAsync(
                $"Coming soon for explore command\n");
                
        ///<summary>
        ///get builds compilation docs
        ///</summary>  
        [Command("build")]
        public Task Build()
            => ReplyAsync(
                $"Coming soon for build command\n");
                
        ///<summary>
        ///get hidden class/rank 8 class unlock guides docs
        ///</summary>  
        [Command("unlock")]
        public Task Unlock()
            => ReplyAsync(
                $"Coming soon for unlock command\n");
                
        ///<summary>
        ///get reddit link for newbie/returning player discussion
        ///</summary>  
        [Command("faq")]
        public Task Fa()
            => ReplyAsync(
                $"Coming soon for faq command\n");
                
        ///<summary>
        ///get link to download latest addon manager
        ///</summary>  
        [Command("addon")]
        public Task AddOn()
            => ReplyAsync(
                $"Coming soon for addon command\n");
                
        ///<summary>
        ///get link for guide and class breakdown
        ///</summary>  
        [Command("get"), Alias("item")]
        public Task Get()
            => ReplyAsync(
                $"Coming soon for get command\n");

                
        ///<summary>
        ///get pastebin link for ktos/ktest patch notes translation from Greyhiem & Gwenyth.
        ///</summary>          [Command("skill")]
        public Task Skill()
            => ReplyAsync(
                $"Coming soon for skill command\n");
    }
}
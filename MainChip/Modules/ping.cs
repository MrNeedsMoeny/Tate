﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace MainChip.Modules
{



    public class ping : ModuleBase<SocketCommandContext>
    {
        [Command("Hello")]
        public async Task PingAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle("Hello")
                .WithDescription("How are you?")
                .WithColor(Color.Gold);


            await ReplyAsync("", false, builder.Build());
        }



        [Command("WhoisTing")]
        public async Task Pingasync()
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle("LordTing?")
                .WithDescription("He is the one, the only...... burrito man")
                .WithColor(Color.Blue);


            await ReplyAsync("", false, builder.Build());

        }
    }



    }
   
    

   

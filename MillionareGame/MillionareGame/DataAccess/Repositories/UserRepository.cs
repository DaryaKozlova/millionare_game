﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MillionareGame.DataAccess.Models;
using Newtonsoft.Json;

namespace MillionareGame.DataAccess.Repositories
{
    public class UserRepository
    {
        private static string _filePath = System.IO.Path.GetFullPath("../../data/users.json");

        public Player SavePlayer(Player player)
        {
            var players = GetAllPlayers();

            if (!players.Exists(existPlayer => existPlayer.Nickname == player.Nickname))
            {
                players.Add(player);

                File.WriteAllText(_filePath,JsonConvert.SerializeObject(players));

                return player;
            }

            return null;
        }

        public Player FindPlayer(string nickname)
        {
            var players = GetAllPlayers();

            var player = players.Find(p => p.Nickname == nickname);

            return player;
        }

        public List<Player> GetAllPlayers()
        {
            List<Player> users = new List<Player>();

            if (File.Exists(_filePath))
            {
                var file = File.ReadAllText(_filePath);
                
                if(file.Length != 0) users = JsonConvert.DeserializeObject<List<Player>>(file);
            }
            else
            {
                File.WriteAllText(_filePath, JsonConvert.SerializeObject(users));
            }

            return users;
        }

        
    }
}

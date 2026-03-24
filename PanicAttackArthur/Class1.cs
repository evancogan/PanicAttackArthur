using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using RDR2;
using RDR2.Native;

namespace PanicAttackArthur
{
    public class PanicAttackArthur : Script
    {
        public PanicAttackArthur()
        {
            Tick += OnTick;
            Interval = 1;
        }

        private void OnTick(object sender, EventArgs evt)
        {
            Ped player = Game.Player.Character;

            Function.Call(RDR2.Native.Hash.START_ENTITY_FIRE, player);

            if (player.Health < 100)
            {
                player.Health = 200;
            }
        }
    }
}
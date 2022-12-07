using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PCommand
{
    public interface CommPattern
    {
        void EatPellet();
        void ReplacePellet();
    }

    public class PelletCommand : CommPattern
    {
        GameObject pelletOb;

        public PelletCommand(GameObject p)
        {
            pelletOb = p;
        }

        public void EatPellet()
        {
            pelletOb.SetActive(false);
        }

        public void ReplacePellet()
        {
            pelletOb.SetActive(true);
        }
    }
}

using System.Collections.Generic;
using Strategy;

namespace StrategyB
{
    public interface IFilmoRodymas
    {
        void RodytiFilma(Filmas filmas);

        void PatikrintiBilietus(List<Bilietas> bilietai);

        void SuleistiZiurovus();
    }
}
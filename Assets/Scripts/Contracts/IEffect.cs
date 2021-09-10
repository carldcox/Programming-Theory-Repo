namespace Contracts
{
    public interface IEffect
    {
        void PlayParticle();
        void PlayRepeatingParticle();
        void StopParticle();
    }
}
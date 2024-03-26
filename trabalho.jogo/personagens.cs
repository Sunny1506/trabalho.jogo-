
namespace trabalho.jogo;

public class personagens 
{
  int fome;
  int sede;
  int sono;



public personagens()
{
  fome=0;

  sede=0;

  sono=0;
}

public void SetFome(int f)
{
    if (f<=1 || f>=0)
       fome=f;
    else if(f > 1)
       fome=1;
    else 
       fome=0;
}

public int GetFome()
{
    return fome;
}

}
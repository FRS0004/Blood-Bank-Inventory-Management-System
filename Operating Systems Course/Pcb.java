public class Pcb
{
    private int lowMem;
    private int highMem;
    private int state;
    private int pid;
   
    public Pcb(int lowMem, int highMem, int state, int pid)
    {
        this.lowMem = lowMem;
        this.highMem = highMem;
        this.state = state;
        this.pid = pid;      
    }
   
    public void setLowMem(int lowMem)
    {
        this.lowMem = lowMem;
    }

    public int getLowMem()
    {
        return lowMem;
    }
   
    public void setHighMem(int highMem)
    {
        this.highMem = highMem;
    }

    public int getHighMem()
    {
        return highMem;
    }
   
    public void setState(int state)
    {
        this.state = state;
    }

    public int getState()
    {
        return state;
    }
   
    public void setPid(int pid)
    {
        this.pid = pid;
    }

    public int getPid()
    {
        return pid;
    }
}

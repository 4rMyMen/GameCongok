
class skill{
    private:
        int skill_id;
        int lv;

}

struct buffstr{
    int bufftype;
    /*
        0 Patk
        1 Pdef
        2 Matk
        3 Mdef
        4 fire add
        5 ice add
        6 thn add
        7 fire def
        8 ice def
        9 thn def
        10 crit chance
        11 critup
    */
    int value;
}

class entity{
    private:
        //base stat
        int Hp;
        int maxHp;
        int Mp;
        int MaxMp;
        int Str;
        int Int;
        int evasion;
        int Const;
        int Speed;
        //battle stat 
        int atktype; //0 slash 1 stab 2 blunt
        int Mdef;
        int Pdef;
        int Patk;
        int Matk;
        int basefire;
        int baseice;
        int basethn;
        bool isdefend;
        List<buff>bufflist
        //special stat
        int cutres;
        int stabres;
        int bluntres;
        int fireres;
        int iceres;
        int thnres;
        //statusres
        int poires;
        int parres;
        
    public:
        void skill(s_id,lv)
        void attack(entity target,int damage_type,bool ispure,double base_multiplier){
            if(random.Next(100)<=target.getEva()){
                //hit
                double mult[100]
                mult[0]=0.0;//Patk
                mult[1]=0.0;//Pdef
                mult[2]=0.0;//Matk
                mult[3]=0.0;//Mdef
                mult[4]=double(basefire);//fir element
                mult[5]=double(baseice);//ice element
                mult[6]=double(basethn);//thn element
                mult[7]=double(fireres);//fir resistance
                mult[8]=double(iceres);//ice resistance
                mult[9]=double(thnres);//thn resistance
                mult[10]=10.0;//crit chance
                mult[11]=1.50;//crit damage
                double atkmultiplier=1*base_multiplier;
                foreach (buff in bufflist){
                    mult[buff.bufftype]+=buff.value;                    
                }
                double targetmult[100]
                targetmult[0]=0.0;//Patk
                targetmult[1]=0.0;//Pdef
                targetmult[2]=0.0;//Matk
                targetmult[3]=0.0;//Mdef
                targetmult[4]=double(basefire);//fir element
                targetmult[5]=double(baseice);//ice element
                targetmult[6]=double(basethn);//thn element
                targetmult[7]=double(fireres);//fir resistance
                targetmult[8]=double(iceres);//ice resistance
                targetmult[9]=double(thnres);//thn resistance
                targetmult[10]=10.0;//crit chance
                targetmult[11]=1.50;//crit damage
                 defmultiplier=1*double()/100;
                foreach (buff in target.bufflist){
                    targetmult[buff.bufftype]+=buff.value;                    
                }
                if(damage_type==0){//phys
                    if(mult[0])atkmultiplier*=mult[0];
                    if(targetmult[1])defmultiplier*=targetmult[1];
                }
                else{//mag
                    if(mult[2])atkmultiplier*=mult[2];
                    if(targetmult[3])defmultiplier*=targetmult[3];
                }
                if(random.Next(100)<=mult[10])atkmultiplier*=mult[11];
                double damage=1;
                if(damage_type==0){//phys
                    damage=1.5*double(Patk)*atkmultiplier-double(target.Pdef)*defmultiplier;
                    damage+=mult[4]*targetmult[7]+mult[5]*targetmult[8]+mult[6]*targetmult[9]    
                }
                else{//mag
                    if(mult[2])atkmultiplier*=mult[2];
                    if(targetmult[3])defmultiplier*=targetmult[3];
                }
                if(target.isdefend){
                    damage=damage/2;                    
                }
            }
        }
        void defend(){
            isdefend=true;
        }
        void hit(int damage){
            Hp-=damage;
        }
        int getMdef(){
            return Mdef;
        }
        int getPdef(){
            return Pdef;
        }
        int getEva(){
            return evasion;
        }
        int getfres(){
            return fireres;
        }
        int getires(){
            return iceres;
        }
        int gettres(){
            return thnres;
        }
        int getcres(){
            return cutres;
        }
        int getsres(){
            return stabres;
        }
        int getbres(){
            return bluntres;
        }
        void 
}

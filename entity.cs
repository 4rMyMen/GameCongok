
class skill{
    private:
        int skill_id;
        int lv;
        int type;//buff/heal/damage

}

struct buffstr{
    int bufftype;
    int value;
    int duration;
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
        float threat;//faktor AI dari rataan damage nanti disebar awalnya rata satu tim 20pc
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
        //damage type1 mag/phys
        //damage type2 null/cut/blunt/stab
        void attack(entity target,int damage_type1,int damage_type2,bool ispure,double base_multiplier){
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
                targetmult[7]=double(fireres)/100;//fir resistance
                targetmult[8]=double(iceres)/100;//ice resistance
                targetmult[9]=double(thnres)/100;//thn resistance
                targetmult[10]=10.0;//crit chance
                targetmult[11]=1.50;//crit damage
                targetmult[12]=double(target.getcres())/100;//fir resistance
                targetmult[13]=double(target.getbres())/100;//ice resistance
                targetmult[14]=double(target.getsres())/100;//thn resistance
                 defmultiplier=1*double()/100;
                foreach (buff in target.bufflist){
                    targetmult[buff.bufftype]+=buff.value;                    
                }
                if(damage_type1==0){//phys
                    if(mult[0])atkmultiplier*=mult[0];
                    if(targetmult[1])defmultiplier*=targetmult[1];
                }
                else{//mag
                    if(mult[2])atkmultiplier*=mult[2];
                    if(targetmult[3])defmultiplier*=targetmult[3];
                }
                if(ispure){
                    if(damage_type==0){//phys
                        damage=1.5*double(Patk)*atkmultiplier
                        damage+=mult[4]+mult[5]+mult[6]  
                    }
                    else{//mag
                        if(mult[2])atkmultiplier*=mult[2];
                        if(damage_type2==1)atkmultiplier*=targetmult[12]
                        if(damage_type2==2)atkmultiplier*=targetmult[13]
                        if(damage_type2==3)atkmultiplier*=targetmult[14]
                        if(targetmult[3])defmultiplier*=targetmult[3];
                }
                    if(random.Next(100)<=mult[10])atkmultiplier*=mult[11];//crit damage
                    double damage=1;
                    if(damage_type1==0){//phys
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

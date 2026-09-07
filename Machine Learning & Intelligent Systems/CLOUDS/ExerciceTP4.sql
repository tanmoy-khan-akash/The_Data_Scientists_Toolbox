/*---------------------------------------------------------------------------------------------------------------------------------------------------
													Question 34
-----------------------------------------------------------------------------------------------------------------------------------------------------*/
select NOM_PROF,count(RESP)
from PROF P,MATIERE M
where NUM_PROF = RESP 
	and NUM_PROF in ( select NUM_PROF from ENSEIGNT )
group by NOM_PROF
order by NOM_PROF desc;

/*---------------------------------------------------------------------------------------------------------------------------------------------------
													Question 35 : ils ont considéré qu'un él_ve qui suit cours represente élèves
-----------------------------------------------------------------------------------------------------------------------------------------------------*/
/*select count (N.NUM_ET) as ET_NOTES
from NOTATION N, ENSEIGNT EN
where N.NUM_ET = EN.NUM_ET and N.CODE = EN.CODE;
-- Je trouve 28 étudiants notés dans les matières qu'ils ont suivis

select count( NUM_ET) as ET_SUIVEURS
from ENSEIGNT EN;
--Je trouve au total 44 étudiants qui ont suivis un cous
-- Puis (28*100)/44 = 63.64% */
	 
select round((cast(ET_NOTES as float)/cast(ET_SUIVEURS as float))*100,2)
from 
(
    select count (N.NUM_ET) as ET_NOTES,
           count( EN.NUM_ET) as ET_SUIVEURS
	from ENSEIGNT EN left outer join NOTATION N on  N.NUM_ET = EN.NUM_ET and N.CODE = EN.CODE 
);

/*---------------------------------------------------------------------------------------------------------------------------------------------------
													Question 36 
-----------------------------------------------------------------------------------------------------------------------------------------------------*/
select N.NUM_ET,NOM_ET, round(avg((COEFF_CC*NOTE_CC + COEFF_TEST*NOTE_TEST)/(COEFF_CC+COEFF_TEST)),2) as MOY_ET ,
   case  
   when avg((COEFF_CC*NOTE_CC + COEFF_TEST*NOTE_TEST)/(COEFF_CC+COEFF_TEST)) >= 10 then 'Admis'
   else 'Ajourne'
   end DECISION_DU_CONSEIL_DE_CLASSE
from ETUDIANT ET, NOTATION N,MATIERE M
where ET.NUM_ET = N.NUM_ET
group by N.NUM_ET,NOM_ET;

/*---------------------------------------------------------------------------------------------------------------------------------------------------
													Question 37
-----------------------------------------------------------------------------------------------------------------------------------------------------*/
select NOM_ET,LIBELLE,round(avg((COEFF_CC*NOTE_CC + COEFF_TEST*NOTE_TEST)/(COEFF_CC+COEFF_TEST)),2) as MOY_ET 
from ETUDIANT ET,MATIERE M,ENSEIGNT EN left outer join NOTATION N on N.CODE = EN.CODE and N.NUM_ET = EN.NUM_ET
where ET.NUM_ET = EN.NUM_ET
  and M.CODE =EN.CODE
group by NOM_ET,LIBELLE
order by NOM_ET asc;
/*---------------------------------------------------------------------------------------------------------------------------------------------------
													Question 38
-----------------------------------------------------------------------------------------------------------------------------------------------------*/
select NOM_PROF, LIBELLE,count(NUM_ET) as NOMBRE_d_ET
from ENSEIGNT EN,MATIERE M,PROF P
where VILLE_PROF = 'Marseille'
   and EN.NUM_PROF = P.NUM_PROF
   and EN.CODE = M.CODE
group by cube(NOM_PROF,LIBELLE)
order by NOM_PROF asc;

/*---------------------------------------------------------------------------------------------------------------------------------------------------
													Question 39 
-----------------------------------------------------------------------------------------------------------------------------------------------------*/
select LIBELLE,ANNEE,round(avg((COEFF_CC*NOTE_CC + COEFF_TEST*NOTE_TEST)/(COEFF_CC+COEFF_TEST)),2) as MOYENNE
from MATIERE M,ETUDIANT ET,NOTATION N 
where N.CODE = M.CODE
   and ET.NUM_ET = N.NUM_ET
group by grouping sets ((LIBELLE,ANNEE),(LIBELLE));
/*---------------------------------------------------------------------------------------------------------------------------------------------------
													Question 40
-----------------------------------------------------------------------------------------------------------------------------------------------------*/
select DISCIPLINE,EN.CODE,NUM_PROF,sum(H_COURS_REA)as NBRE_d_H
from MATIERE M,ENSEIGNT EN
where EN.CODE = M.CODE
group by grouping sets ((DISCIPLINE,EN.CODE,NUM_PROF),(DISCIPLINE,EN.CODE),(DISCIPLINE),());
--group by rollup (DISCIPLINE,EN.CODE,NUM_PROF);

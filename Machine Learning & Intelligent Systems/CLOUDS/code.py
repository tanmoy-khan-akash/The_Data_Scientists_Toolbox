#!/usr/bin/python3.6
#-*-coding:Utf-8-*

#import gradient_descent.py as GD
from gradient_descent import *
import numpy as np

#Ce programme détermine si une année est bissextile ou pas

print("Hello world !")

""" annee = 0

message = "une annee bissextile"

annee = input("Veuillez saisir l'annee : ")
annee = int(annee)

if(annee%4 !=0): print ("Ce n'est pas ",message)
elif(annee%100 !=0): print ("C'est ",message)
elif(annee%400 !=0): print("Ce n'est pas ",message)
else: print("C'est ",message) """

x = np.array[0,1,2,3,4]
y = np.array[1,5,3,7,2]
theta_1 = 1 
theta_2 = 2
learning_rate = 0.2
n_epochs = 3

GD.gradient_descent(x,y,theta_1,theta_2,learning_rate,n_epochs)



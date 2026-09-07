#!/usr/bin/python3.6
import numpy as np
import seaborn as sns
import matplotlib.pyplot as plt
import matplotlib.animation as animation
from scipy import stats

from sklearn.datasets.samples_generator import make_regression


# fonction gradient_descent
def gradient_descent(x,y,theta_1,theta_2,learning_rate,n_epochs):

    m = len(x)

    #construire le vecteur theta
    theta = np.array([theta_1,theta_2])

    #ajouter une colone de 1 à x
    for i in range(m):
        x[i] = np.array([1,x[i]])

    #construire le tableau des pertes
    J_thetas = np.zeros(n_epochs)
    #construire le tableau des gradients
    gradient_J_thetas = np.zeros(n_epochs,2)

    #implementer le gradient descent
    for i in range(n_epochs):

        #calculer(x.theta - y)
        x_dot_theta_minus_y = np.dot(x,theta) - y

        #calculer la fonction loss de la i-eme iteration
        J_thetas[i] = 0.5*np.dot(x_dot_theta_minus_y,x_dot_theta_minus_y)
        print("la fonction loss de l'itteration i  est egale a ", J_thetas[i])

        #calculer le gradient de la i-eme iteration
        gradient_J_thetas[i] = np.dot(x,x_dot_theta_minus_y)
        print("le gradient de l'itteration i  est egale a ", gradient_J_thetas[i])

        #faire evoluer theta
        theta = theta - learning_rate*gradient_J_thetas[i]
        print ("le nouveau theta est : ", theta)   






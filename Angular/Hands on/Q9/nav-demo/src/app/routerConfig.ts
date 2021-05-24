import { Routes } from '@angular/router';

import { HomeComponent } from './component/home/home.component';

import { AboutComponent } from './component/about/about.component';

import { LoginComponent } from './component/login/login.component';

export const appRoutes: Routes = [

{ path: 'home', component: HomeComponent },

{ path: 'about',component: AboutComponent},

{ path: 'login',component: LoginComponent}];
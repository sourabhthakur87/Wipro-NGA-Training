import { Routes } from '@angular/router';
import { Setup } from './component/setup/setup';
import { Play } from './component/play/play';
import { Result } from './component/result/result';

export const routes: Routes = [
    {path:"",component:Setup},
    {path:"play",component:Play},
    {path:"history",component:Result}
];

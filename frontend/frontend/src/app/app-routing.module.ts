import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainappComponent } from './calculator/mainapp/mainapp.component';


const routes: Routes = [
  {
    path: 'calculate',
    component: MainappComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

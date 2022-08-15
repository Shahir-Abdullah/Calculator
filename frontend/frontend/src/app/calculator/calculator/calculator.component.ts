import { Component} from '@angular/core';
import { CalculateService } from 'src/app/Services/calculate.service';


@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent{

  public calculation : number;
  public inputNumber : number;
  constructor(private calculationService : CalculateService) { 
    this.calculation = 0;
    this.inputNumber = 0;
  }
  
  calculate(operation : string){
    this.calculationService.getCalculation(operation, this.inputNumber).subscribe((response:number) => {
      this.calculation = response;
    }
    );
  }

  sqrt(){
    this.calculate("sqrt");
  }

  sq(){
    this.calculate("sq");
  }

  fact(){
    this.calculate("fact");
  }

  fibbo(){
    this.calculate("fibbo");
  }



}

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
  
  sqrt(){
    this.calculationService.getCalculation("sqrt", this.inputNumber).subscribe((response:number) => {
      this.calculation = response;
    }
    );
  }

  sq(){
    this.calculationService.getCalculation("sq", this.inputNumber).subscribe((response:number) => {
      this.calculation = response;
    }
    );
  }

  fact(){
    this.calculationService.getCalculation("fact", this.inputNumber).subscribe((response:number) => {
      this.calculation = response;
    }
    );
  }

  fibbo(){
    this.calculationService.getCalculation("fibbo", this.inputNumber).subscribe((response:number) => {
      this.calculation = response;
    }
    );
  }



}

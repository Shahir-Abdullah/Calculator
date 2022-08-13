import { Component} from '@angular/core';
import { CalculateService } from 'src/app/Services/calculate.service';
import { OperationLog } from 'src/app/Models/operationLog';

@Component({
  selector: 'app-history',
  templateUrl: './history.component.html',
  styleUrls: ['./history.component.css']
})
export class HistoryComponent{

  public n : number;
  public operationhistory: OperationLog[] = [];
  constructor(private calculationService : CalculateService) { 
    this.n = 0;
  }

  getNHistory(){
    if(this.n == null)this.n = 0;
    this.calculationService.getNHistory(this.n).subscribe(
      (response:OperationLog[]) => {
        this.operationhistory = response;
        //console.log(this.operationhistory);
      }
    )
  }



  

}

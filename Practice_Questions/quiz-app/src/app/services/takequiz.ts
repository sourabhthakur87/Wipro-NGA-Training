import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class Takequiz {
  private quizDataSource = new BehaviorSubject<any[]>([]);
  quizData$ = this.quizDataSource.asObservable();

  setQuizData(data:any[]){
    this.quizDataSource.next(data)
  }
}

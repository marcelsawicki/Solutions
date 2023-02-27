import { Component } from '@angular/core';
import { TodoList } from './todoList';
import { TodoItem } from './todoItem';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  private list = new TodoList("Adam",
  [new TodoItem("Iść pobiegać", true), 
  new TodoItem("Kupić kwiaty"), 
  new TodoItem("Odebrać bilaty")]);

  get username(): string{
    return this.list.user;
  }

  get itemcount(): number {
    return this.list.items.filter(item => !item.complete).length;
  }
  get items(): readonly TodoItem[] {
    return this.list.items;
  }
}

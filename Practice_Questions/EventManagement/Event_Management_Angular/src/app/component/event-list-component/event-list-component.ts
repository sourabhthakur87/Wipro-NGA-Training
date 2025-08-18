import { Component } from '@angular/core';

@Component({
  selector: 'app-event-list-component',
  standalone: false,
  templateUrl: './event-list-component.html',
  styleUrl: './event-list-component.css'
})
export class EventListComponent {
 events = [
  { name: 'Future Tech Summit', date: '2025-09-15', price: 4200, category: 'Conference' },
  { name: 'Gourmet Cooking Workshop', date: '2025-08-28', price: 1200, category: 'Workshop' },
  { name: 'Summer Beats Music Festival', date: '2025-11-02', price: 3000, category: 'Concert' },
  { name: 'Global Health Conference', date: '2025-12-10', price: 5100, category: 'Conference' },
  { name: 'Interior Design Masterclass', date: '2025-10-08', price: 1700, category: 'Workshop' },
  { name: 'Drone Innovation Expo', date: '2025-09-27', price: 2600, category: 'Conference' },
  { name: 'Classical Music Night', date: '2025-11-25', price: 1900, category: 'Concert' },
  { name: 'Fitness & Wellness Retreat', date: '2025-10-18', price: 2200, category: 'Workshop' },
  { name: 'Digital Marketing Bootcamp', date: '2025-08-30', price: 950, category: 'Workshop' },
  { name: 'World Entrepreneurs Forum', date: '2025-12-20', price: 3700, category: 'Conference' }
];


}

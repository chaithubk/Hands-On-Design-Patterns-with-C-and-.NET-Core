import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import {Product} from '../product';
import { identifierModuleUrl } from '@angular/compiler';
@Injectable({
  providedIn: 'root'
})
export class ProductserviceService {
  httpOptions = {
    headers: new HttpHeaders({'Content-Type': 'application/json'})
  };

  // base api url - should not hard-code here
  // should come from config files
  apiurl = 'http://localhost:59712/api/product/';
  //   apiurl = 'http://localhost:5000/api/product/';
  constructor(private http: HttpClient) { }
  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.apiurl + 'productlist');
  }
getProductDetails(id) {
  return this.http.get(this.apiurl + 'product/' + id);
}
createProduct(data) {
  console.log(JSON.stringify(data));
  return this.http.post(this.apiurl + 'addproduct/',
  JSON.stringify(data),
  this.httpOptions);
}
updateProduct(data) {
    return this.http.post<Product>(this.apiurl + 'updateproduct/',
    JSON.stringify(data),
    this.httpOptions);
}
deleteProduct(id) {
  return this.http.get(this.apiurl + 'deleteproduct/' + id);
}

}

/**
 * SGC-Miage V1.0
 * JavaInUse API reference for developers
 *
 * OpenAPI spec version: 1.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */
/* tslint:disable:no-unused-variable member-ordering */

import { Inject, Injectable, Optional }                      from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams,
         HttpResponse, HttpEvent }                           from '@angular/common/http';
import { CustomHttpUrlEncodingCodec }                        from '../encoder';

import { Observable }                                        from 'rxjs';

import { Employe } from '../model/employe';
import { EmployeRequest } from '../model/employeRequest';

import { BASE_PATH, COLLECTION_FORMATS }                     from '../variables';
import { Configuration }                                     from '../configuration';


@Injectable()
export class EmployeControllerService {

    protected basePath = 'https://localhost:8080';
    public defaultHeaders = new HttpHeaders();
    public configuration = new Configuration();

    constructor(protected httpClient: HttpClient, @Optional()@Inject(BASE_PATH) basePath: string, @Optional() configuration: Configuration) {
        if (basePath) {
            this.basePath = basePath;
        }
        if (configuration) {
            this.configuration = configuration;
            this.basePath = basePath || configuration.basePath || this.basePath;
        }
    }

    /**
     * @param consumes string[] mime-types
     * @return true: consumes contains 'multipart/form-data', false: otherwise
     */
    private canConsumeForm(consumes: string[]): boolean {
        const form = 'multipart/form-data';
        for (const consume of consumes) {
            if (form === consume) {
                return true;
            }
        }
        return false;
    }


    /**
     * Creer un nouvel employe dans la base de donnees
     * 
     * @param employe employe
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public createEmployeUsingPUT(employe: Employe, observe?: 'body', reportProgress?: boolean): Observable<boolean>;
    public createEmployeUsingPUT(employe: Employe, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<boolean>>;
    public createEmployeUsingPUT(employe: Employe, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<boolean>>;
    public createEmployeUsingPUT(employe: Employe, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        if (employe === null || employe === undefined) {
            throw new Error('Required parameter employe was null or undefined when calling createEmployeUsingPUT.');
        }

        let headers = this.defaultHeaders;

        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
            '*/*'
        ];
        const httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set('Accept', httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        const consumes: string[] = [
            'application/json'
        ];
        const httpContentTypeSelected: string | undefined = this.configuration.selectHeaderContentType(consumes);
        if (httpContentTypeSelected != undefined) {
            headers = headers.set('Content-Type', httpContentTypeSelected);
        }

        return this.httpClient.put<boolean>(`${this.basePath}/api/sgc/employe/create`,
            employe,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * deleteEmploye
     * 
     * @param id id
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public deleteEmployeUsingDELETE(id: string, observe?: 'body', reportProgress?: boolean): Observable<boolean>;
    public deleteEmployeUsingDELETE(id: string, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<boolean>>;
    public deleteEmployeUsingDELETE(id: string, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<boolean>>;
    public deleteEmployeUsingDELETE(id: string, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        if (id === null || id === undefined) {
            throw new Error('Required parameter id was null or undefined when calling deleteEmployeUsingDELETE.');
        }

        let headers = this.defaultHeaders;

        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
            '*/*'
        ];
        const httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set('Accept', httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        const consumes: string[] = [
        ];

        return this.httpClient.delete<boolean>(`${this.basePath}/api/sgc/employe/delete/${encodeURIComponent(String(id))}`,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * Retourne l&#39;ensemble des employes present dans la base de donnees
     * 
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public getAllEmployeUsingGET(observe?: 'body', reportProgress?: boolean): Observable<Array<Employe>>;
    public getAllEmployeUsingGET(observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<Array<Employe>>>;
    public getAllEmployeUsingGET(observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<Array<Employe>>>;
    public getAllEmployeUsingGET(observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        let headers = this.defaultHeaders;

        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
            '*/*'
        ];
        const httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set('Accept', httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        const consumes: string[] = [
        ];

        return this.httpClient.get<Array<Employe>>(`${this.basePath}/api/sgc/employe/all`,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * getEmploiByQuery
     * 
     * @param query query
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public getEmploiByQueryUsingGET1(query: EmployeRequest, observe?: 'body', reportProgress?: boolean): Observable<Array<Employe>>;
    public getEmploiByQueryUsingGET1(query: EmployeRequest, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<Array<Employe>>>;
    public getEmploiByQueryUsingGET1(query: EmployeRequest, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<Array<Employe>>>;
    public getEmploiByQueryUsingGET1(query: EmployeRequest, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        if (query === null || query === undefined) {
            throw new Error('Required parameter query was null or undefined when calling getEmploiByQueryUsingGET1.');
        }

        let headers = this.defaultHeaders;

        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
            '*/*'
        ];
        const httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set('Accept', httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        const consumes: string[] = [
        ];
        const httpContentTypeSelected: string | undefined = this.configuration.selectHeaderContentType(consumes);
        if (httpContentTypeSelected != undefined) {
            headers = headers.set('Content-Type', httpContentTypeSelected);
        }

        return this.httpClient.get<Array<Employe>>(`${this.basePath}/api/sgc/employe/query`,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * Retourne l&#39;employe associe a l&#39;id donne
     * 
     * @param id id
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public getEmployeUsingGET(id: string, observe?: 'body', reportProgress?: boolean): Observable<Employe>;
    public getEmployeUsingGET(id: string, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<Employe>>;
    public getEmployeUsingGET(id: string, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<Employe>>;
    public getEmployeUsingGET(id: string, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        if (id === null || id === undefined) {
            throw new Error('Required parameter id was null or undefined when calling getEmployeUsingGET.');
        }

        let headers = this.defaultHeaders;

        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
            '*/*'
        ];
        const httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set('Accept', httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        const consumes: string[] = [
        ];

        return this.httpClient.get<Employe>(`${this.basePath}/api/sgc/employe/${encodeURIComponent(String(id))}`,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * Mets a jour les informations d&#39;un emploi
     * 
     * @param employe employe
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public updateEmployeUsingPOST(employe: Employe, observe?: 'body', reportProgress?: boolean): Observable<boolean>;
    public updateEmployeUsingPOST(employe: Employe, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<boolean>>;
    public updateEmployeUsingPOST(employe: Employe, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<boolean>>;
    public updateEmployeUsingPOST(employe: Employe, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        if (employe === null || employe === undefined) {
            throw new Error('Required parameter employe was null or undefined when calling updateEmployeUsingPOST.');
        }

        let headers = this.defaultHeaders;

        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
            '*/*'
        ];
        const httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set('Accept', httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        const consumes: string[] = [
            'application/json'
        ];
        const httpContentTypeSelected: string | undefined = this.configuration.selectHeaderContentType(consumes);
        if (httpContentTypeSelected != undefined) {
            headers = headers.set('Content-Type', httpContentTypeSelected);
        }

        return this.httpClient.post<boolean>(`${this.basePath}/api/sgc/employe/update`,
            employe,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

}
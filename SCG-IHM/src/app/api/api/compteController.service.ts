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

import { Compte } from '../model/compte';
import { CompteRequest } from '../model/compteRequest';

import { BASE_PATH, COLLECTION_FORMATS }                     from '../variables';
import { Configuration }                                     from '../configuration';


@Injectable()
export class CompteControllerService {

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
     * Creer un nouveau dans la base de donnees
     * 
     * @param compte compte
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public createAccountUsingPUT(compte?: Compte, observe?: 'body', reportProgress?: boolean): Observable<boolean>;
    public createAccountUsingPUT(compte?: Compte, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<boolean>>;
    public createAccountUsingPUT(compte?: Compte, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<boolean>>;
    public createAccountUsingPUT(compte?: Compte, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {


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

        return this.httpClient.put<boolean>(`${this.basePath}/api/sgc/compte/create`,
            compte,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * Supprimer un compte de la base
     * 
     * @param id id
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public deleteCompteByIdUsingDELETE(id: string, observe?: 'body', reportProgress?: boolean): Observable<boolean>;
    public deleteCompteByIdUsingDELETE(id: string, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<boolean>>;
    public deleteCompteByIdUsingDELETE(id: string, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<boolean>>;
    public deleteCompteByIdUsingDELETE(id: string, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        if (id === null || id === undefined) {
            throw new Error('Required parameter id was null or undefined when calling deleteCompteByIdUsingDELETE.');
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

        return this.httpClient.delete<boolean>(`${this.basePath}/api/sgc/compte/delete/${encodeURIComponent(String(id))}`,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * Retourne le compte avec associe a l&#39;id
     * 
     * @param id id
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public getAccountUsingGET(id: string, observe?: 'body', reportProgress?: boolean): Observable<Compte>;
    public getAccountUsingGET(id: string, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<Compte>>;
    public getAccountUsingGET(id: string, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<Compte>>;
    public getAccountUsingGET(id: string, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        if (id === null || id === undefined) {
            throw new Error('Required parameter id was null or undefined when calling getAccountUsingGET.');
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

        return this.httpClient.get<Compte>(`${this.basePath}/api/sgc/compte/${encodeURIComponent(String(id))}`,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * Retourne l&#39;ensemble des comptes presents en base de donnees
     * 
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public getAllAccountUsingGET(observe?: 'body', reportProgress?: boolean): Observable<Array<Compte>>;
    public getAllAccountUsingGET(observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<Array<Compte>>>;
    public getAllAccountUsingGET(observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<Array<Compte>>>;
    public getAllAccountUsingGET(observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

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

        return this.httpClient.get<Array<Compte>>(`${this.basePath}/api/sgc/compte/all`,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * Retourne une liste de compte en fonction de parametre
     * 
     * @param query query
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public getCompteByQueryUsingGET(query: CompteRequest, observe?: 'body', reportProgress?: boolean): Observable<Array<Compte>>;
    public getCompteByQueryUsingGET(query: CompteRequest, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<Array<Compte>>>;
    public getCompteByQueryUsingGET(query: CompteRequest, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<Array<Compte>>>;
    public getCompteByQueryUsingGET(query: CompteRequest, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        if (query === null || query === undefined) {
            throw new Error('Required parameter query was null or undefined when calling getCompteByQueryUsingGET.');
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

        return this.httpClient.get<Array<Compte>>(`${this.basePath}/api/sgc/compte/query`,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * Mets a jour les informations d&#39;un compte
     * 
     * @param compte compte
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public updateAccountUsingPOST(compte: Compte, observe?: 'body', reportProgress?: boolean): Observable<boolean>;
    public updateAccountUsingPOST(compte: Compte, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<boolean>>;
    public updateAccountUsingPOST(compte: Compte, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<boolean>>;
    public updateAccountUsingPOST(compte: Compte, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        if (compte === null || compte === undefined) {
            throw new Error('Required parameter compte was null or undefined when calling updateAccountUsingPOST.');
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

        return this.httpClient.post<boolean>(`${this.basePath}/api/sgc/compte/update`,
            compte,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

}
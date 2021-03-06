#region license
// Copyright (c) 2007-2010 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using ElasticSearch.Client;
using ElasticSearch.Client.DSL;
using NHibernate;

namespace ElasticSearch.NHibernate {
  public interface IElasticSearchSession : ISession
  {
    QueryResponse RawQuery(string query, params string[] typeNames);
    IElasticSearchQuery CreateFullTextQuery(Query search);
    void Index(object o);
    bool PurgeAll(Type type);
    bool PurgeAll();
    bool PurgeAll(string indexName);
    void Refresh();
    bool CreateAlias(string indexName, string alias);
    bool CreateIndex(string indexName);
    bool DeleteAllDocs(string indexName);
    bool DeleteMultiple(string indexName, string data);
  }
}
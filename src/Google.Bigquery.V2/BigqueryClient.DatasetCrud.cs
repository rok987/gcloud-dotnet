﻿// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Bigquery.v2.Data;
using System;
using System.Collections.Generic;

namespace Google.Bigquery.V2
{
    public abstract partial class BigqueryClient
    {
        /// <summary>
        /// Retrieves a dataset within this client's project given the dataset ID.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="GetDataset(DatasetReference)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <returns>The requested dataset.</returns>
        public virtual BigqueryDataset GetDataset(string datasetId) =>
            GetDataset(GetDatasetReference(datasetId));

        /// <summary>
        /// Retrieves a dataset given a project ID and dataset ID.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="GetDataset(DatasetReference)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <returns>The requested dataset.</returns>
        public virtual BigqueryDataset GetDataset(string projectId, string datasetId) =>
            GetDataset(GetDatasetReference(projectId, datasetId));

        /// <summary>
        /// Retrieves a dataset.
        /// </summary>
        /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
        /// <returns>The requested dataset.</returns>
        public virtual BigqueryDataset GetDataset(DatasetReference datasetReference)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the datasets within this client's project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListDatasets(ProjectReference, ListDatasetsOptions)"/>.
        /// </summary>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>The datasets within this project.</returns>
        public virtual IEnumerable<BigqueryDataset> ListDatasets(ListDatasetsOptions options = null) =>
            ListDatasets(GetProjectReference(ProjectId), options);

        /// <summary>
        /// Lists the datasets within the specified project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListDatasets(ProjectReference, ListDatasetsOptions)"/>.
        /// </summary>
        /// <param name="projectId">The project to list the datasets from. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>The datasets within the specified project.</returns>
        public virtual IEnumerable<BigqueryDataset> ListDatasets(string projectId, ListDatasetsOptions options = null) =>
            ListDatasets(GetProjectReference(projectId), options);

        /// <summary>
        /// Lists the datasets within the specified project.
        /// This method just creates a <see cref="ProjectReference"/> and delegates to <see cref="ListDatasets(ProjectReference, ListDatasetsOptions)"/>.
        /// </summary>
        /// <param name="projectReference">A fully-qualified identifier for the project. Must not be null.</param>
        /// <param name="options">The options for the operation. May be null, in which case
        /// defaults will be supplied.</param>
        /// <returns>The datasets within the specified project.</returns>
        public virtual IEnumerable<BigqueryDataset> ListDatasets(ProjectReference projectReference, ListDatasetsOptions options = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a dataset with the specified ID in this client's project.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="CreateDataset(DatasetReference)"/>.
        /// </summary>
        /// <param name="datasetId">The new dataset ID. Must not be null.</param>
        /// <returns>The created dataset.</returns>
        public virtual BigqueryDataset CreateDataset(string datasetId) =>
            CreateDataset(GetDatasetReference(datasetId));

        /// <summary>
        /// Creates a dataset with the specified ID in specified project.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="CreateDataset(DatasetReference)"/>.
        /// </summary>
        /// <param name="projectId">The ID of the project in which to create the dataset. Must not be null.</param>
        /// <param name="datasetId">The new dataset ID. Must not be null.</param>
        /// <returns>The created dataset.</returns>
        public virtual BigqueryDataset CreateDataset(string projectId, string datasetId) =>
            CreateDataset(GetDatasetReference(projectId, datasetId));

        /// <summary>
        /// Creates the specified dataset.
        /// </summary>
        /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
        /// <returns>The created dataset.</returns>
        public virtual BigqueryDataset CreateDataset(DatasetReference datasetReference)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Attempts to fetch the specified dataset within this client's project, creating it if it doesn't exist.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="GetOrCreateDataset(DatasetReference)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <returns>The existing or new dataset.</returns>
        public virtual BigqueryDataset GetOrCreateDataset(string datasetId) =>
            GetOrCreateDataset(GetDatasetReference(datasetId));

        /// <summary>
        /// Attempts to fetch the specified dataset within the given project, creating it if it doesn't exist.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="GetOrCreateDataset(DatasetReference)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        /// <returns>The existing or new dataset.</returns>
        public virtual BigqueryDataset GetOrCreateDataset(string projectId, string datasetId) =>
            GetOrCreateDataset(GetDatasetReference(projectId, datasetId));

        /// <summary>
        /// Attempts to fetch the specified dataset, creating it if it doesn't exist.
        /// </summary>
        /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
        /// <returns>The existing or new dataset.</returns>
        public virtual BigqueryDataset GetOrCreateDataset(DatasetReference datasetReference)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the specified dataset within this client's project.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="DeleteDataset(DatasetReference)"/>.
        /// </summary>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        public virtual void DeleteDataset(string datasetId) =>
            DeleteDataset(GetDatasetReference(datasetId));

        /// <summary>
        /// Deletes the specified dataset within the given project.
        /// This method just creates a <see cref="DatasetReference"/> and delegates to <see cref="DeleteDataset(DatasetReference)"/>.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be null.</param>
        /// <param name="datasetId">The dataset ID. Must not be null.</param>
        public virtual void DeleteDataset(string projectId, string datasetId) =>
            DeleteDataset(GetDatasetReference(projectId, datasetId));

        /// <summary>
        /// Deletes the specified dataset.
        /// </summary>
        /// <param name="datasetReference">A fully-qualified identifier for the dataset. Must not be null.</param>
        public virtual void DeleteDataset(DatasetReference datasetReference)
        {
            throw new NotImplementedException();
        }
    }
}

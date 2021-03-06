import React, { useContext } from 'react';
import { Table } from 'semantic-ui-react';
import { observer } from 'mobx-react-lite';
import { format } from 'date-fns';
import { RootStoreContext } from '../../../app/stores/rootStore';

export const DelegatedTaskList: React.FC = () => {
  const rootStore = useContext(RootStoreContext);
  const {
    delegatedTasksByDate,
    selectDelegatedTask,
    selectedDelegatedTask,
  } = rootStore.delegatedTaskStore;

  return (
    <>
      <Table celled selectable sortable>
        <Table.Header>
          <Table.Row>
            <Table.HeaderCell>Assignment</Table.HeaderCell>
            <Table.HeaderCell>Task</Table.HeaderCell>
            <Table.HeaderCell>Deadline</Table.HeaderCell>
            <Table.HeaderCell>Notes</Table.HeaderCell>
          </Table.Row>
        </Table.Header>
        {delegatedTasksByDate.map((delegatedTask) => (
          <Table.Body key={delegatedTask.id}>
            <Table.Row
              onClick={() => selectDelegatedTask(delegatedTask.id)}
              active={
                selectedDelegatedTask !== undefined &&
                selectedDelegatedTask.id == delegatedTask.id
              }
            >
              <Table.Cell>{delegatedTask.assignment}</Table.Cell>
              <Table.Cell>{delegatedTask.type}</Table.Cell>
              <Table.Cell>{format(delegatedTask.deadline, 'P p')}</Table.Cell>
              <Table.Cell>{delegatedTask.notes}</Table.Cell>
            </Table.Row>
          </Table.Body>
        ))}
      </Table>
    </>
  );
};

export default observer(DelegatedTaskList);
